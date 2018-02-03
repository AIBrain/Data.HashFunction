using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace System.Data.HashFunction {

    /// <summary>
    /// Static class to provide extension functions for IHashFunction instances.
    /// </summary>
    public static class IHashFunction_Extensions {

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">Hash function to use.</param>
        /// <param name="data">        Data to be hashed.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, Boolean data ) {
            return hashFunction.ComputeHash(
                BitConverter.GetBytes( data ) );
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">Hash function to use.</param>
        /// <param name="data">        Data to be hashed.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, Byte data ) {
            return hashFunction.ComputeHash(
                new[] { data } );
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">Hash function to use.</param>
        /// <param name="data">        Data to be hashed.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, Char data ) {
            return hashFunction.ComputeHash(
                BitConverter.GetBytes( data ) );
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">Hash function to use.</param>
        /// <param name="data">        Data to be hashed.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, Double data ) {
            return hashFunction.ComputeHash(
                BitConverter.GetBytes( data ) );
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">Hash function to use.</param>
        /// <param name="data">        Data to be hashed.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, Single data ) {
            return hashFunction.ComputeHash(
                BitConverter.GetBytes( data ) );
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">Hash function to use.</param>
        /// <param name="data">        Data to be hashed.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, Int32 data ) {
            return hashFunction.ComputeHash(
                BitConverter.GetBytes( data ) );
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">Hash function to use.</param>
        /// <param name="data">        Data to be hashed.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, Int64 data ) {
            return hashFunction.ComputeHash(
                BitConverter.GetBytes( data ) );
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">Hash function to use.</param>
        /// <param name="data">        Data to be hashed.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, SByte data ) {
            return hashFunction.ComputeHash(
                new[] { ( Byte )data } );
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">Hash function to use.</param>
        /// <param name="data">        Data to be hashed.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, Int16 data ) {
            return hashFunction.ComputeHash(
                BitConverter.GetBytes( data ) );
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">Hash function to use.</param>
        /// <param name="data">        Data to be hashed.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        /// <remarks>UTF-8 encoding used to convert string to bytes.</remarks>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, String data ) {
            return hashFunction.ComputeHash(
                Encoding.UTF8.GetBytes( data ) );
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">Hash function to use.</param>
        /// <param name="data">        Data to be hashed.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, UInt32 data ) {
            return hashFunction.ComputeHash(
                BitConverter.GetBytes( data ) );
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">Hash function to use.</param>
        /// <param name="data">        Data to be hashed.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, UInt64 data ) {
            return hashFunction.ComputeHash(
                BitConverter.GetBytes( data ) );
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">Hash function to use.</param>
        /// <param name="data">        Data to be hashed.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, UInt16 data ) {
            return hashFunction.ComputeHash(
                BitConverter.GetBytes( data ) );
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <typeparam name="ModelT">Type of data to be hashed.</typeparam>
        /// <param name="hashFunction">Hash function to use.</param>
        /// <param name="data">        Data to be hashed.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        /// <remarks><see cref="BinaryFormatter"/> is used to turn given data into a byte array.</remarks>
        public static Byte[] ComputeHash<ModelT>( this IHashFunction hashFunction, ModelT data ) {
            using ( var memoryStream = new MemoryStream() ) {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize( memoryStream, data );

                return hashFunction.ComputeHash(
                    memoryStream.ToArray() );
            }
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">   Hash function to use.</param>
        /// <param name="data">           Data to be hashed.</param>
        /// <param name="desiredHashSize">Desired size of resulting hash, in bits.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, Boolean data, Int32 desiredHashSize ) {
            return hashFunction.ComputeHash(
                BitConverter.GetBytes( data ),
                desiredHashSize );
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">   Hash function to use.</param>
        /// <param name="data">           Data to be hashed.</param>
        /// <param name="desiredHashSize">Desired size of resulting hash, in bits.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, Byte data, Int32 desiredHashSize ) {
            return hashFunction.ComputeHash(
                new[] { data },
                desiredHashSize );
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">   Hash function to use.</param>
        /// <param name="data">           Data to be hashed.</param>
        /// <param name="desiredHashSize">Desired size of resulting hash, in bits.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, Char data, Int32 desiredHashSize ) {
            return hashFunction.ComputeHash(
                BitConverter.GetBytes( data ),
                desiredHashSize );
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">   Hash function to use.</param>
        /// <param name="data">           Data to be hashed.</param>
        /// <param name="desiredHashSize">Desired size of resulting hash, in bits.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, Double data, Int32 desiredHashSize ) {
            return hashFunction.ComputeHash(
                BitConverter.GetBytes( data ),
                desiredHashSize );
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">   Hash function to use.</param>
        /// <param name="data">           Data to be hashed.</param>
        /// <param name="desiredHashSize">Desired size of resulting hash, in bits.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, Single data, Int32 desiredHashSize ) {
            return hashFunction.ComputeHash(
                BitConverter.GetBytes( data ),
                desiredHashSize );
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">   Hash function to use.</param>
        /// <param name="data">           Data to be hashed.</param>
        /// <param name="desiredHashSize">Desired size of resulting hash, in bits.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, Int32 data, Int32 desiredHashSize ) {
            return hashFunction.ComputeHash(
                BitConverter.GetBytes( data ),
                desiredHashSize );
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">   Hash function to use.</param>
        /// <param name="data">           Data to be hashed.</param>
        /// <param name="desiredHashSize">Desired size of resulting hash, in bits.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, Int64 data, Int32 desiredHashSize ) {
            return hashFunction.ComputeHash(
                BitConverter.GetBytes( data ),
                desiredHashSize );
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">   Hash function to use.</param>
        /// <param name="data">           Data to be hashed.</param>
        /// <param name="desiredHashSize">Desired size of resulting hash, in bits.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, SByte data, Int32 desiredHashSize ) {
            return hashFunction.ComputeHash(
                new[] { ( Byte )data },
                desiredHashSize );
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">   Hash function to use.</param>
        /// <param name="data">           Data to be hashed.</param>
        /// <param name="desiredHashSize">Desired size of resulting hash, in bits.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, Int16 data, Int32 desiredHashSize ) {
            return hashFunction.ComputeHash(
                BitConverter.GetBytes( data ),
                desiredHashSize );
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">   Hash function to use.</param>
        /// <param name="data">           Data to be hashed.</param>
        /// <param name="desiredHashSize">Desired size of resulting hash, in bits.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        /// <remarks>UTF-8 encoding used to convert string to bytes.</remarks>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, String data, Int32 desiredHashSize ) {
            return hashFunction.ComputeHash(
                Encoding.UTF8.GetBytes( data ),
                desiredHashSize );
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">   Hash function to use.</param>
        /// <param name="data">           Data to be hashed.</param>
        /// <param name="desiredHashSize">Desired size of resulting hash, in bits.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, UInt32 data, Int32 desiredHashSize ) {
            return hashFunction.ComputeHash(
                BitConverter.GetBytes( data ),
                desiredHashSize );
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">   Hash function to use.</param>
        /// <param name="data">           Data to be hashed.</param>
        /// <param name="desiredHashSize">Desired size of resulting hash, in bits.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, UInt64 data, Int32 desiredHashSize ) {
            return hashFunction.ComputeHash(
                BitConverter.GetBytes( data ),
                desiredHashSize );
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">   Hash function to use.</param>
        /// <param name="data">           Data to be hashed.</param>
        /// <param name="desiredHashSize">Desired size of resulting hash, in bits.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, UInt16 data, Int32 desiredHashSize ) {
            return hashFunction.ComputeHash(
                BitConverter.GetBytes( data ),
                desiredHashSize );
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <typeparam name="ModelT">Type of data to be hashed.</typeparam>
        /// <param name="hashFunction">   Hash function to use.</param>
        /// <param name="data">           Data to be hashed.</param>
        /// <param name="desiredHashSize">Desired size of resulting hash, in bits.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        /// <remarks><see cref="BinaryFormatter"/> is used to turn given data into a byte array.</remarks>
        public static Byte[] ComputeHash<ModelT>( this IHashFunction hashFunction, ModelT data, Int32 desiredHashSize ) {
            using ( var memoryStream = new MemoryStream() ) {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize( memoryStream, data );

                return hashFunction.ComputeHash(
                    memoryStream.ToArray(),
                    desiredHashSize );
            }
        }

        /// <summary>
        /// Computes hash value for given data.
        /// </summary>
        /// <param name="hashFunction">   Hash function to use.</param>
        /// <param name="data">           Data to be hashed.</param>
        /// <param name="desiredHashSize">Desired size of resulting hash, in bits.</param>
        /// <returns>Hash value of the data as byte array.</returns>
        public static Byte[] ComputeHash( this IHashFunction hashFunction, Byte[] data, Int32 desiredHashSize ) {
            var hash = new BigInteger();
            var desiredHashBytes = ( desiredHashSize + 7 ) / 8;

            var seededData = new Byte[data.Length + 4];
            Array.Copy( data, 0, seededData, 4, data.Length );

            var hashesNeeded = ( desiredHashSize + ( hashFunction.HashSize - 1 ) ) / hashFunction.HashSize;

            // Compute as many hashes as needed
            for ( var x = 0; x < Math.Max( hashesNeeded, 1 ); ++x ) {
                Byte[] currentData;

                if ( x != 0 ) {
                    Array.Copy( BitConverter.GetBytes( x ), seededData, 4 );
                    currentData = seededData;
                }
                else {

                    // Use original data for first
                    currentData = data;
                }

                var elementHash = new BigInteger(
                    hashFunction.ComputeHash( currentData )
                        .Concat( new[] { ( Byte )0 } )
                        .ToArray() );

                hash |= elementHash << ( x * hashFunction.HashSize );
            }

            // XOr-fold the extra bits
            if ( hashesNeeded * hashFunction.HashSize != desiredHashSize ) {
                var mask = ( ( new BigInteger( 1 ) << desiredHashSize ) - 1 );

                hash = ( hash ^ ( hash >> desiredHashSize ) ) & mask;
            }

            // Convert to array that contains desiredHashSize bits
            var hashBytes = hash.ToByteArray();

            // Account for missing or extra bytes.
            if ( hashBytes.Length != desiredHashBytes ) {
                var buffer = new Byte[desiredHashBytes];
                Array.Copy( hashBytes, buffer, Math.Min( hashBytes.Length, desiredHashBytes ) );

                hashBytes = buffer;
            }

            return hashBytes;
        }
    }
}
