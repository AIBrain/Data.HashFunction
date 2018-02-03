﻿using System.Collections.Generic;
using System.Data.HashFunction.Utilities.IntegerManipulation;

namespace System.Data.HashFunction {

    /// <summary>
    /// Implementation of Fowler–Noll–Vo hash function (FNV-1a) as specified at http://www.isthe.com/chongo/tech/comp/fnv/index.html.
    /// </summary>
    public class FNV1a
        : FNV1Base {

        /// <summary>
        /// Initializes a new instance of the <see cref="FNV1a"/> class.
        /// </summary>
        /// <inheritdoc cref="FNV1Base()"/>
        public FNV1a()
            : base() {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FNV1a"/> class.
        /// </summary>
        /// <inheritdoc cref="FNV1Base(int)"/>
        public FNV1a( Int32 hashSize )
            : base( hashSize ) {
        }

        /// <inheritdoc/>
#if !NET40

        protected override void ProcessBytes( ref UInt32[] hash, IReadOnlyList<UInt32> prime, Byte[] data, Int32 position, Int32 length )
#else
        protected override void ProcessBytes(ref UInt32[] hash, IList<UInt32> prime, byte[] data, int position, int length)
#endif
        {
            for ( var x = position; x < position + length; ++x ) {
                hash[0] ^= data[x];
                hash = hash.ExtendedMultiply( prime );
            }
        }

        /// <inheritdoc/>
        protected override void ProcessBytes32( ref UInt32 hash, UInt32 prime, Byte[] data, Int32 position, Int32 length ) {
            for ( var x = position; x < position + length; ++x ) {
                hash ^= data[x];
                hash *= prime;
            }
        }

        /// <inheritdoc/>
        protected override void ProcessBytes64( ref UInt64 hash, UInt64 prime, Byte[] data, Int32 position, Int32 length ) {
            for ( var x = position; x < position + length; ++x ) {
                hash ^= data[x];
                hash *= prime;
            }
        }
    }
}
