using System.IO;

namespace System.Data.HashFunction {

    /// <summary>
    /// Common interface to non-cryptographic hash functions.
    /// </summary>
    public interface IHashFunction {

        /// <summary>
        /// Size of produced hash, in bits.
        /// </summary>
        /// <value>The size of the hash, in bits.</value>
        Int32 HashSize { get; }

        /// <summary>
        /// Computes hash value for given byte array.
        /// </summary>
        /// <param name="data">Array of data to hash.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        Byte[] ComputeHash( Byte[] data );

        /// <summary>
        /// Computes hash value for given stream.
        /// </summary>
        /// <param name="data">Stream of data to hash.</param>
        /// <returns>Hash value of data as byte array.</returns>
        Byte[] ComputeHash( Stream data );
    }
}
