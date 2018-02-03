﻿using System.Collections.Generic;
using System.Data.HashFunction.Utilities.UnifiedData;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace System.Data.HashFunction {

    /// <summary>
    /// Abstract implementation of Pearson hashing as specified at
    /// http://en.wikipedia.org/wiki/Pearson_hashing and http://cs.mwsu.edu/~griffin/courses/2133/downloads/Spring11/p677-pearson.pdf.
    /// </summary>
    [SuppressMessage( "Microsoft.Design", "CA1012:AbstractTypesShouldNotHaveConstructors",
        Justification = "Constructor required to validate implementer's parameters." )]
    public abstract class PearsonBase
#if !NET40 || INCLUDE_ASYNC
        : HashFunctionAsyncBase
#else
        : HashFunctionBase
#endif
    {
        /// <summary>
        /// 256-item read only collection of bytes. Must be a permutation of [0, 255].
        /// </summary>
        /// <value>The 256-item read only collection of bytes.</value>
#if !NET40

        public IReadOnlyList<Byte> T { get { return _T; } }

#else
        public IList<byte> T { get { return _T; } }
#endif

#if !NET40
        private readonly IReadOnlyList<Byte> _T;
#else
        private readonly IList<byte> _T;
#endif

#if !NET40

        /// <remarks>Defaults <see cref="HashFunctionBase.HashSize"/> to 8.</remarks>
        /// <inheritdoc cref="PearsonBase(IReadOnlyList{byte}, int)"/>
        public PearsonBase( IReadOnlyList<Byte> t )
#else

        /// <remarks>Defaults <see cref="HashFunctionBase.HashSize"/> to 8.</remarks>
        /// <inheritdoc cref="PearsonBase(IList{byte}, int)"/>
        public PearsonBase(IList<byte> t)
#endif
            : this( t, 8 ) {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PearsonBase"/> class.
        /// </summary>
        /// <param name="t">       <inheritdoc cref="T"/></param>
        /// <param name="hashSize">
        /// <inheritdoc cref="HashFunctionBase(int)"/>. hashSize is allowed to be any positive
        /// integer that is divisible by 8.
        /// </param>
        /// <exception cref="System.ArgumentNullException">t</exception>
        /// <exception cref="System.ArgumentException">t must be a permutation of [0, 255].;t</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// hashSize;hashSize must be a positive integer that is divisible by 8.
        /// </exception>
        /// <inheritdoc cref="HashFunctionBase(int)"/>
#if !NET40

        public PearsonBase( IReadOnlyList<Byte> t, Int32 hashSize )
#else
        public PearsonBase(IList<byte> t, int hashSize)
#endif
            : base( hashSize ) {
            if ( t == null ) {
                throw new ArgumentNullException( "t" );
            }

            if ( t.Count != 256 || t.Distinct().Count() != 256 ) {
                throw new ArgumentException( "t must be a permutation of [0, 255].", "t" );
            }

            if ( hashSize <= 0 || hashSize % 8 != 0 ) {
                throw new ArgumentOutOfRangeException( "hashSize", "hashSize must be a positive integer that is divisible by 8." );
            }

            _T = t;
        }

        /// <inheritdoc/>
        protected override Byte[] ComputeHashInternal( UnifiedData data ) {
            var h = new Byte[HashSize / 8];
            Boolean firstByte = true;

            data.ForEachRead( ( dataBytes, position, length ) => {
                ProcessBytes( ref h, ref firstByte, dataBytes, position, length );
            } );

            return h;
        }

#if !NET40 || INCLUDE_ASYNC

        /// <inheritdoc/>
        protected override async Task<Byte[]> ComputeHashAsyncInternal( UnifiedData data ) {
            var h = new Byte[HashSize / 8];
            Boolean firstByte = true;

            await data.ForEachReadAsync( ( dataBytes, position, length ) => {
                ProcessBytes( ref h, ref firstByte, dataBytes, position, length );
            } ).ConfigureAwait( false );

            return h;
        }

#endif

        private void ProcessBytes( ref Byte[] h, ref Boolean firstByte, Byte[] dataBytes, Int32 position, Int32 length ) {
            for ( var x = position; x < position + length; ++x ) {
                for ( Int32 y = 0; y < HashSize / 8; ++y ) {
                    if ( !firstByte ) {
                        h[y] = this.T[h[y] ^ dataBytes[x]];
                    }
                    else {
                        h[y] = this.T[( dataBytes[x] + y ) & 0xff];
                    }
                }

                firstByte = false;
            }
        }
    }
}
