﻿using System;
using System.Collections.Generic;
using System.Data.HashFunction.Core;
using System.Data.HashFunction.Core.Utilities;
using System.Data.HashFunction.Core.Utilities.UnifiedData;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.HashFunction.SpookyHash
{
    /// <summary>
    /// Implements SpookyHash V2 as specified at http://burtleburtle.net/bob/hash/spooky.html.
    /// </summary>
    internal class SpookyHashV2_Implementation
        : HashFunctionAsyncBase,
            ISpookyHashV2
    {

        /// <summary>
        /// Configuration used when creating this instance.
        /// </summary>
        /// <value>
        /// A clone of configuration that was used when creating this instance.
        /// </value>
        public ISpookyHashConfig Config => _config.Clone();


        private readonly ISpookyHashConfig _config;
        
        private static readonly IEnumerable<int> _validHashSizes = new HashSet<int>() { 32, 64, 128 };



        /// <summary>
        /// Initializes a new instance of the <see cref="SpookyHashV2_Implementation"/> class.
        /// </summary>
        /// <param name="hashSize"><inheritdoc cref="HashFunctionBase(int)" /></param>
        /// <param name="initVal1"><inheritdoc cref="InitVal1" /></param>
        /// <param name="initVal2"><inheritdoc cref="InitVal2" /></param>
        /// <exception cref="System.ArgumentNullException"><paramref name="config"/></exception>
        /// <exception cref="System.ArgumentOutOfRangeException"><paramref name="config"/>.<see cref="ISpookyHashConfig.HashSizeInBits"/>;<paramref name="config"/>.<see cref="ISpookyHashConfig.HashSizeInBits"/> must be contained within SpookyHashV1.ValidHashSizes.</exception>
        /// <inheritdoc cref="HashFunctionBase(int)" />
        public SpookyHashV2_Implementation(ISpookyHashConfig config)
            : base((config?.HashSizeInBits).GetValueOrDefault())
        {
            if (config == null)
                throw new ArgumentNullException(nameof(config));

            _config = config.Clone();


            if (!_validHashSizes.Contains(config.HashSizeInBits))
                throw new ArgumentOutOfRangeException($"{nameof(config)}.{nameof(config.HashSizeInBits)}", $"{nameof(config)}.{nameof(config.HashSizeInBits)} must be contained within SpookyHashV2.ValidHashSizes.");
        }



        /// <exception cref="System.InvalidOperationException">HashSize set to an invalid value.</exception>
        /// <inheritdoc />
        protected override byte[] ComputeHashInternal(IUnifiedData data, CancellationToken cancellationToken)
        {
            UInt64[] h = new UInt64[12];

            h[0] = h[3] = h[6] = h[9] = _config.Seed;
            h[1] = h[4] = h[7] = h[10] = (HashSizeInBits == 128 ? _config.Seed2 : _config.Seed);
            h[2] = h[5] = h[8] = h[11] = 0XDEADBEEFDEADBEEF;


            var remainderData = new byte[96];

            data.ForEachGroup(96, 
                (dataGroup, position, length) => {
                    Mix(h, dataGroup, position, length);
                },
                (remainder, position, length) => {
                    Array.Copy(remainder, position, remainderData, 0, length);
                    remainderData[95] = (byte) length;
                },
                cancellationToken);


            End(h, remainderData, 0);


            byte[] hash;

            switch (_config.HashSizeInBits)
            {
                case 32:
                    hash = BitConverter.GetBytes((UInt32) h[0]);
                    break;

                case 64:
                    hash = BitConverter.GetBytes(h[0]);
                    break;

                case 128:
                    hash = new byte[16];

                    BitConverter.GetBytes(h[0])
                        .CopyTo(hash, 0);

                    BitConverter.GetBytes(h[1])
                        .CopyTo(hash, 8);

                    break;

                default:
                    throw new NotImplementedException();
            }

            return hash;
        }

        /// <exception cref="System.InvalidOperationException">HashSize set to an invalid value.</exception>
        /// <inheritdoc />
        protected override async Task<byte[]> ComputeHashAsyncInternal(IUnifiedDataAsync data, CancellationToken cancellationToken)
        {
            UInt64[] h = new UInt64[12];

            h[0] = h[3] = h[6] = h[9] = _config.Seed;
            h[1] = h[4] = h[7] = h[10] = (HashSizeInBits == 128 ? _config.Seed2 : _config.Seed);
            h[2] = h[5] = h[8] = h[11] = 0XDEADBEEFDEADBEEF;


            var remainderData = new byte[96];

            await data.ForEachGroupAsync(96, 
                    (dataGroup, position, length) => {
                        Mix(h, dataGroup, position, length);
                    },
                    (remainder, position, length) => {
                        Array.Copy(remainder, position, remainderData, 0, length);
                        remainderData[95] = (byte) length;
                    },
                    cancellationToken)
                .ConfigureAwait(false);


            End(h, remainderData, 0);


            byte[] hash;

            switch (_config.HashSizeInBits)
            {
                case 32:
                    hash = BitConverter.GetBytes((UInt32)h[0]);
                    break;

                case 64:
                    hash = BitConverter.GetBytes(h[0]);
                    break;

                case 128:
                    hash = new byte[16];

                    BitConverter.GetBytes(h[0])
                        .CopyTo(hash, 0);

                    BitConverter.GetBytes(h[1])
                        .CopyTo(hash, 8);

                    break;
        
                default:
                    throw new NotImplementedException();
            }

            return hash;
        }


        private static readonly IReadOnlyList<int> _MixRotationParameters = 
            new[] {
                11, 32, 43, 31, 17,28, 39, 57, 55, 54, 22, 46
            };

        private void Mix(UInt64[] h, byte[] data, int position, int length)
        {
            for (int x = position; x < position + length; x += 96)
            {
                for (var i = 0; i < 12; ++i)
                {
                    h[i]             += BitConverter.ToUInt64(data, x + (i * 8)); 
                    h[(i +  2) % 12] ^= h[(i + 10) % 12]; 
                    h[(i + 11) % 12] ^= h[i];
                    h[i]              = RotateLeft(h[i], _MixRotationParameters[i]); 
                    h[(i + 11) % 12] += h[(i + 1) % 12];
                }
            }
        }


        private static readonly IReadOnlyList<int> _EndPartialRotationParameters = 
            new[] {
                44, 15, 34, 21, 38, 33, 10, 13, 38, 53, 42, 54
            };

        private void EndPartial(UInt64[] h)
        {
            for (int i = 0; i < 12; ++i)
            {
                h[(i + 11) % 12] += h[(i + 1) % 12]; 
                h[(i +  2) % 12] ^= h[(i + 11) % 12]; 
                h[(i +  1) % 12] = RotateLeft(h[(i + 1) % 12], _EndPartialRotationParameters[i]);
            }
        }

        private void End(UInt64[] h, byte[] data, int position)
        {
            for (int i = 0; i < 12; ++i)
            {
                h[i] += BitConverter.ToUInt64(data, position + (i * 8));
            }
             
            EndPartial(h);
            EndPartial(h);
            EndPartial(h);
        }

        private static UInt64 RotateLeft(UInt64 operand, int shiftCount)
        {
            shiftCount &= 0x3f;

            return
                (operand << shiftCount) |
                (operand >> (64 - shiftCount));
        }

    }
}