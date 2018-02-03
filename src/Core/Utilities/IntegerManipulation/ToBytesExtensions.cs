namespace System.Data.HashFunction.Utilities.IntegerManipulation
{
    /// <summary>
    /// Static class to provide ToBytes extension functions.
    /// </summary>
    internal static class ToBytesExtensions
    {
        /// <summary>
        /// Converts integer to the smallest byte array that will fit the integers low-order bitLength bits.
        /// </summary>
        /// <param name="value">The value to convert to bytes.</param>
        /// <param name="bitLength">Number of bits to use from the provided value.</param>
        /// <returns>An smallest possible array of bytes that contains all of the low-order bitLength bits.</returns>
        /// <remarks>Any extra high-order bits in the last byte are guaranteed to be zero.</remarks>
        /// <exception cref="System.ArgumentOutOfRangeException">bitLength;bitLength but be in the range [1, 8].</exception>
        public static Byte[] ToBytes(this Byte value, Int32 bitLength)
        {
            if (bitLength <= 0 || bitLength > 8)
                throw new ArgumentOutOfRangeException("bitLength", "bitLength but be in the range [1, 8].");


            value &= (Byte) (Byte.MaxValue >> (8 - bitLength));


            return new Byte[] { 
                value 
            };
        }

        /// <exception cref="System.ArgumentOutOfRangeException">bitLength;bitLength but be in the range [1, 16].</exception>
        /// <inheritdoc cref="ToBytes(byte, int)"/>
        public static Byte[] ToBytes(this UInt16 value, Int32 bitLength)
        {
            if (bitLength <= 0 || bitLength > 16)
                throw new ArgumentOutOfRangeException("bitLength", "bitLength but be in the range [1, 16].");


            value &= (UInt16) (UInt16.MaxValue >> (16 - bitLength));


            var valueBytes = new Byte[(bitLength + 7) / 8];

            for (Int32 x = 0; x < valueBytes.Length; ++x)
            {
                valueBytes[x] = (Byte)value;
                value >>= 8;
            }

            return valueBytes;
        }

        /// <exception cref="System.ArgumentOutOfRangeException">bitLength;bitLength but be in the range [1, 32].</exception>
        /// <inheritdoc cref="ToBytes(byte, int)"/>
        public static Byte[] ToBytes(this UInt32 value, Int32 bitLength)
        {
            if (bitLength <= 0 || bitLength > 32)
                throw new ArgumentOutOfRangeException("bitLength", "bitLength but be in the range [1, 32].");


            value &= (UInt32.MaxValue >> (32 - bitLength));


            var valueBytes = new Byte[(bitLength + 7) / 8];

            for (Int32 x = 0; x < valueBytes.Length; ++x)
            {
                valueBytes[x] = (Byte) value;
                value >>= 8;
            }

            return valueBytes;
        }

        /// <exception cref="System.ArgumentOutOfRangeException">bitLength;bitLength but be in the range [1, 64].</exception>
        /// <inheritdoc cref="ToBytes(byte, int)"/>
        public static Byte[] ToBytes(this UInt64 value, Int32 bitLength)
        {
            if (bitLength <= 0 || bitLength > 64)
                throw new ArgumentOutOfRangeException("bitLength", "bitLength but be in the range [1, 64].");


            value &= (UInt64.MaxValue >> (64 - bitLength));


            var valueBytes = new Byte[(bitLength + 7) / 8];

            for (Int32 x = 0; x < valueBytes.Length; ++x)
            {
                valueBytes[x] = (Byte)value;
                value >>= 8;
            }

            return valueBytes;
        }
    }
}
