using System.Data.HashFunction.Utilities.UnifiedData;
using System.IO;

namespace System.Data.HashFunction {

    /// <summary>
    /// Abstract implementation of an IHashFunction. Provides convenience checks and ensures a
    /// default HashSize has been set at construction.
    /// </summary>
    public abstract class HashFunctionBase
        : IHashFunction {
        private readonly Int32 _HashSize;

        /// <summary>
        /// Initializes a new instance of the <see cref="HashFunctionBase"/> class.
        /// </summary>
        /// <param name="hashSize"><inheritdoc cref="HashSize"/></param>
        protected HashFunctionBase( Int32 hashSize ) {
            _HashSize = hashSize;
        }

        /// <summary>
        /// Flag to determine if a hash function needs a seekable stream in order to calculate the
        /// hash. Override to true to make <see cref="ComputeHash(Stream)"/> pass a seekable stream
        /// to <see cref="ComputeHashInternal(UnifiedData)"/>.
        /// </summary>
        /// <value><c>true</c> if a seekable stream; otherwise, <c>false</c>.</value>
        protected virtual Boolean RequiresSeekableStream { get { return false; } }

        /// <inheritdoc/>
        public Int32 HashSize {
            get { return _HashSize; }
        }

        /// <summary>
        /// Computes hash value for given stream.
        /// </summary>
        /// <param name="data">Data to hash.</param>
        /// <returns>Hash value of data as byte array.</returns>
        protected abstract Byte[] ComputeHashInternal( UnifiedData data );

        /// <inheritdoc/>
        public virtual Byte[] ComputeHash( Byte[] data ) {
            return ComputeHashInternal(
                new ArrayData( data ) );
        }

        /// <exception cref="System.ArgumentException">Stream \data\ must be readable.;data</exception>
        /// <inheritdoc/>
        public virtual Byte[] ComputeHash( Stream data ) {
            if ( !data.CanRead ) {
                throw new ArgumentException( "Stream \"data\" must be readable.", "data" );
            }

            if ( !data.CanSeek && RequiresSeekableStream ) {
                Byte[] buffer;

                using ( var ms = new MemoryStream() ) {
                    data.CopyTo( ms );

                    buffer = ms.ToArray();
                }

                return ComputeHashInternal(
                    new ArrayData( buffer ) );
            }

            return ComputeHashInternal(
                new StreamData( data ) );
        }
    }
}
