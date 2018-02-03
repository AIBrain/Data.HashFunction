namespace System.Data.HashFunction.Utilities.IntegerManipulation {

    /// <summary>
    /// Static class to provide ReflectBits extension functions.
    /// </summary>
    internal static class ReflectBitsExtensions {

        /// <summary>
        /// Reflects the low-order bits of an integer.
        /// </summary>
        /// <param name="value">    The integer value to reflect.</param>
        /// <param name="bitLength">Number of low-order bits to reflect.</param>
        /// <returns>New integer whose low-order bitLength number of bits have been reflected.</returns>
        /// <remarks>Any non-included high orders bits will be zeroed out in the returned integer.</remarks>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// bitLength;bitLength must be in the range [1, 8].
        /// </exception>
        public static Byte ReflectBits( this Byte value, Int32 bitLength ) {
            if ( bitLength <= 0 || bitLength > 8 ) {
                throw new ArgumentOutOfRangeException( nameof(bitLength), "bitLength must be in the range [1, 8]." );
            }

            Byte reflectedValue = 0;

            for ( var x = 0; x < bitLength; ++x ) {
                reflectedValue <<= 1;

                reflectedValue |= ( Byte )( value & 1 );

                value >>= 1;
            }

            return reflectedValue;
        }

        /// <exception cref="System.ArgumentOutOfRangeException">
        /// bitLength;bitLength must be in the range [1, 16].
        /// </exception>
        /// <inheritdoc cref="ReflectBits(byte, int)"/>
        public static UInt16 ReflectBits( this UInt16 value, Int32 bitLength ) {
            if ( bitLength <= 0 || bitLength > 16 ) {
                throw new ArgumentOutOfRangeException( nameof(bitLength), "bitLength must be in the range [1, 16]." );
            }

            UInt16 reflectedValue = 0;

            for ( var x = 0; x < bitLength; ++x ) {
                reflectedValue <<= 1;

                reflectedValue |= ( UInt16 )( value & 1 );

                value >>= 1;
            }

            return reflectedValue;
        }

        /// <exception cref="System.ArgumentOutOfRangeException">
        /// bitLength;bitLength must be in the range [1, 32]
        /// </exception>
        /// <inheritdoc cref="ReflectBits(byte, int)"/>
        public static UInt32 ReflectBits( this UInt32 value, Int32 bitLength ) {
            if ( bitLength <= 0 || bitLength > 32 ) {
                throw new ArgumentOutOfRangeException( nameof(bitLength), "bitLength must be in the range [1, 32]." );
            }

            var reflectedValue = 0U;

            for ( var x = 0; x < bitLength; ++x ) {
                reflectedValue <<= 1;

                reflectedValue |= ( value & 1 );

                value >>= 1;
            }

            return reflectedValue;
        }

        /// <exception cref="System.ArgumentOutOfRangeException">
        /// bitLength;bitLength must be in the range [1, 64]
        /// </exception>
        /// <inheritdoc cref="ReflectBits(byte, int)"/>
        public static UInt64 ReflectBits( this UInt64 value, Int32 bitLength ) {
            if ( bitLength <= 0 || bitLength > 64 ) {
                throw new ArgumentOutOfRangeException( nameof(bitLength), "bitLength must be in the range [1, 64]." );
            }

            var reflectedValue = 0UL;

            for ( var x = 0; x < bitLength; ++x ) {
                reflectedValue <<= 1;

                reflectedValue |= ( value & 1 );

                value >>= 1;
            }

            return reflectedValue;
        }
    }
}
