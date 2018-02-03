﻿using System.Collections.Generic;
using System.Data.HashFunction.Utilities;
using System.Data.HashFunction.Utilities.UnifiedData;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace System.Data.HashFunction
{
	/// <summary>
	/// Implementation of BLAKE2b as specified at https://blake2.net/.  Modified from the canonical C# port at 
    /// https://blake2.net/blake2_code_20140114.zip. Supports a hash output size of 8 through 512 bits in 8-bit increments 
    /// and allows seeding with a key, salt, and/or personalization sequence.
	/// </summary>
	public partial class Blake2B
#if !NET40 || INCLUDE_ASYNC
		: HashFunctionAsyncBase
#else
		: HashFunctionBase
#endif
	{
        private readonly UInt32 _originalKeyLength;
        private readonly Byte[] _key;
        private readonly Byte[] _salt;
        private readonly Byte[] _personalization;


		private const Int32 MinHashSizeBits = 8;
		private const Int32 MaxHashSizeBits = 512;
		private const Int32 DefaultHashSizeBits = 512;

		private const Int32 MaxKeySizeBytes = 64;
		private const Int32 SaltSizeBytes = 16;
		private const Int32 PersonalizationSizeBytes = 16;

		private const Int32 BlockSizeBytes = 128;

        private static readonly UInt64[] IVs = new[] { 
            0x6A09E667F3BCC908UL,
		    0xBB67AE8584CAA73BUL,
            0x3C6EF372FE94F82BUL,
            0xA54FF53A5F1D36F1UL,
            0x510E527FADE682D1UL,
            0x9B05688C2B3E6C1FUL,
            0x1F83D9ABFB41BD6BUL,
            0x5BE0CD19137E2179UL
        };



        private class InternalState
        {
            public Int32 BufferFilled = 0;
            public readonly Byte[] Buffer = new Byte[128];

            public readonly UInt64[] H = new UInt64[8];
            public UInt128 Counter;
            public readonly UInt64[] FinalizationFlags = new UInt64[2];


            public InternalState(Int32 hashSize, UInt32 originalKeyLength, Byte[] salt, Byte[] personalization)
            {
                Array.Copy(IVs, H, IVs.Length);

                H[0] ^= 0x01010000U |
                    ((UInt32) hashSize / 8) |
                    (originalKeyLength << 8);


                H[4] ^= BitConverter.ToUInt64(salt, 0);
                H[5] ^= BitConverter.ToUInt64(salt, 8);

                H[6] ^= BitConverter.ToUInt64(personalization, 0);
                H[7] ^= BitConverter.ToUInt64(personalization, 8);
            }
        }



		/// <summary>
		/// Initializes an instance of the <see cref="Blake2B"/> class with the default settings
		/// (no key, no salt, no personalization, and 512 output length).
		/// </summary>
		public Blake2B()
			: this(DefaultHashSizeBits)
		{

		}

		/// <summary>
		/// Initializes an instance of the <see cref="Blake2B"/> class with the provided
		/// <paramref name="hashSize"/> (no key, no salt, no personalization). 
		/// 
		/// The <paramref name="hashSize"/> must be 8 bits at the least and 512 bits at most, and 
		/// the size in bits must be a multiple of 8.
		/// </summary>
		/// <param name="hashSize">Hash size to use for the output</param>
		/// <exception cref="ArgumentOutOfRangeException">
		/// The provided <paramref name="hashSize"/> is invalid.
		/// </exception>
		public Blake2B(Int32 hashSize)
            : this(hashSize, null, null, null)
		{

		}

        
		/// <summary>
		/// Initializes an instance of the <see cref="Blake2B"/> class with the default hash size. 
        /// If not null, the <paramref name="key"/>, <paramref name="salt"/>, and 
        /// <paramref name="personalization"/> arguments will be applied to the hashing algorithm. 
		/// 
		/// The <paramref name="key"/> parameter must be a byte sequence of at most 64 bytes.
		/// The <paramref name="salt"/> parameter must be a byte sequence of exactly 16 bytes.
		/// The <paramref name="personalization"/> parameter must be a byte sequence of exactly 16 
		/// bytes.
		/// </summary>
		/// <param name="key">Key to seed the hash with</param>
		/// <param name="salt">Salt to seed the hash with</param>
		/// <param name="personalization">Personalization to seed the hash with</param>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Either the provided <paramref name="key"/> length, <paramref name="salt"/> length, 
        /// or <paramref name="personalization"/> length is invalid.
		/// </exception>
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Justification = "Default values only for named parameter usage.")]
        public Blake2B(Byte[] key = null, Byte[] salt = null, Byte[] personalization = null)
            : this(DefaultHashSizeBits, key, salt, personalization)
        {

        }

		/// <summary>
		/// Initializes an instance of the <see cref="Blake2B"/> class with the provided
		/// <paramref name="hashSize"/>. If not null, the <paramref name="key"/>, 
		/// <paramref name="salt"/>, and <paramref name="personalization"/> arguments will be 
		/// applied to the hashing algorithm. 
		/// 
		/// The <paramref name="hashSize"/> must be 8 bits at the least and 512 bits at most, and 
		/// the size in bits must be a multiple of 8.
		/// The <paramref name="key"/> parameter must be a byte sequence of at most 64 bytes.
		/// The <paramref name="salt"/> parameter must be a byte sequence of exactly 16 bytes.
		/// The <paramref name="personalization"/> parameter must be a byte sequence of exactly 16 
		/// bytes.
		/// </summary>
		/// <param name="key">Key to seed the hash with</param>
		/// <param name="salt">Salt to seed the hash with</param>
		/// <param name="personalization">Personalization to seed the hash with</param>
		/// <param name="hashSize">Hash size to use for the output</param>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Either the provided <paramref name="hashSize"/>, <paramref name="key"/> length, 
		/// <paramref name="salt"/> length, or <paramref name="personalization"/> length is invalid.
		/// </exception>
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Justification = "Default values only for named parameter usage.")]
        public Blake2B(Int32 hashSize, IEnumerable<Byte> key = null, IEnumerable<Byte> salt = null, IEnumerable<Byte> personalization = null)
			: base(hashSize)
        {
            if (hashSize < MinHashSizeBits || hashSize > MaxHashSizeBits)
                throw new ArgumentOutOfRangeException("hashSize", hashSize, String.Format("Expected: {0} >= hashSize <= {1}", MinHashSizeBits, MaxHashSizeBits));

			if (hashSize % 8 != 0)
				throw new ArgumentOutOfRangeException("hashSize", hashSize, "The hash size must be a multiple of 8");

            var keyArray = (key ?? new Byte[0]).ToArray();
            var saltArray = (salt ?? new Byte[16]).ToArray();
            var personalizationArray = (personalization ?? new Byte[16]).ToArray();

			if (keyArray.Length > MaxKeySizeBytes)
				throw new ArgumentOutOfRangeException("key", key, String.Format("Expected: key.Length <= {0}", MaxKeySizeBytes));

			if (saltArray.Length != SaltSizeBytes)
				throw new ArgumentOutOfRangeException("salt", salt, String.Format("Expected: salt.Length == {0}", SaltSizeBytes));

			if (personalizationArray.Length != PersonalizationSizeBytes)
				throw new ArgumentOutOfRangeException("personalization", personalization, String.Format("Expected: personalization.Length == {0}", PersonalizationSizeBytes));



            _originalKeyLength = (UInt32) keyArray.Length;

            _key = new Byte[128];
            Array.Copy(keyArray, _key, keyArray.Length);

			_salt = saltArray;
			_personalization = personalizationArray;
		}


		/// <inheritdoc />
		protected override Byte[] ComputeHashInternal(UnifiedData data)
		{
            var internalState = new InternalState(HashSize, _originalKeyLength, _salt, _personalization);


			if (_originalKeyLength > 0)
				ProcessBytes(internalState, _key, 0, _key.Length);

            data.ForEachGroup(
                BlockSizeBytes,
                (array, start, count) => ProcessBytes(internalState, array, start, count),
                (array, start, count) => ProcessBytes(internalState, array, start, count));

            return Final(HashSize, internalState);
		}


#if !NET40 || INCLUDE_ASYNC

		/// <inheritdoc />
		protected override async Task<Byte[]> ComputeHashAsyncInternal(UnifiedData data)
		{
            var internalState = new InternalState(HashSize, _originalKeyLength, _salt, _personalization);


            if (_originalKeyLength > 0)
                ProcessBytes(internalState, _key, 0, _key.Length);

			await data.ForEachGroupAsync(
                BlockSizeBytes,
                (array, start, count) => ProcessBytes(internalState, array, start, count),
                (array, start, count) => ProcessBytes(internalState, array, start, count));

			return Final(HashSize, internalState);
		}

#endif


        private static void ProcessBytes(InternalState internalState, Byte[] array, Int32 start, Int32 count)
        {
			Int32 bufferRemaining = BlockSizeBytes - internalState.BufferFilled;

			if (internalState.BufferFilled > 0 && count > bufferRemaining)
			{
				Array.Copy(
                    array, start, 
                    internalState.Buffer, internalState.BufferFilled, 
                    bufferRemaining);


				internalState.Counter += BlockSizeBytes;
				
                Compress(internalState, internalState.Buffer, 0);

				start += bufferRemaining;
				count -= bufferRemaining;
				internalState.BufferFilled = 0;
			}

			while (count > BlockSizeBytes)
			{
				internalState.Counter += BlockSizeBytes;
				
				Compress(internalState, array, start);
				
                start += BlockSizeBytes;
				count -= BlockSizeBytes;
			}

			if (count > 0)
			{
				Array.Copy(
                    array, start, 
                    internalState.Buffer, internalState.BufferFilled, 
                    count);

				internalState.BufferFilled += count;
			}
		}


		private static Byte[] Final(Int32 hashSize, InternalState internalState)
		{
			//Last compression
			internalState.Counter += (UInt32) internalState.BufferFilled;
			internalState.FinalizationFlags[0] = UInt64.MaxValue;

			for (Int32 i = internalState.BufferFilled; i < internalState.Buffer.Length; i++)
				internalState.Buffer[i] = 0;

			Compress(internalState, internalState.Buffer, 0);


			Byte[] hash = new Byte[64];

            for (Int32 i = 0; i < 8; ++i)
            {
                Array.Copy(
                    BitConverter.GetBytes(internalState.H[i]), 0, 
                    hash, i * 8, 
                    8);
            }


            if (hash.Length != hashSize / 8)
			{
                var result = new Byte[hashSize / 8];

				Array.Copy(
                    hash, 
                    result, result.Length);


				return result;
			}

			return hash;
		}

		private static void Compress(InternalState internalState, Byte[] block, Int32 start)
		{
            var m = new UInt64[16];
		    Buffer.BlockCopy(block, start, m, 0, BlockSizeBytes);


            var v = new UInt64[16];
            Array.Copy(internalState.H, v, internalState.H.Length);
            Array.Copy(IVs, 0, v, 8, IVs.Length);

			v[12] ^= internalState.Counter.Low;
			v[13] ^= internalState.Counter.High;
			v[14] ^= internalState.FinalizationFlags[0];
			v[15] ^= internalState.FinalizationFlags[1];


            ComputeRounds(v, m);

			//Finalization
			internalState.H[0] ^= v[0] ^ v[8];
			internalState.H[1] ^= v[1] ^ v[9];
			internalState.H[2] ^= v[2] ^ v[10];
			internalState.H[3] ^= v[3] ^ v[11];
			internalState.H[4] ^= v[4] ^ v[12];
			internalState.H[5] ^= v[5] ^ v[13];
			internalState.H[6] ^= v[6] ^ v[14];
			internalState.H[7] ^= v[7] ^ v[15];
		}
	}
}
