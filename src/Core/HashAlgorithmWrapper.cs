using System.IO;
using System.Security.Cryptography;

namespace System.Data.HashFunction {

    /// <summary>
    /// Implementation of <see cref="IHashFunction"/> that wraps cryptographic hash functions known
    /// as <see cref="HashAlgorithm"/>.
    /// </summary>
    public class HashAlgorithmWrapper
        : IHashFunction, IDisposable {
        private readonly HashAlgorithm _hashAlgorithm;

        private readonly Boolean _ownsInstance;

        private readonly Object SyncRoot = new Object();

        private Boolean _disposed = false;

        /// <remarks>
        /// Assumes ownership of the <see cref="HashAlgorithm"/> instance and disposes it when the
        /// <see cref="HashAlgorithmWrapper"/> is disposed.
        /// </remarks>
        /// <inheritdoc cref="HashAlgorithmWrapper(HashAlgorithm, bool)"/>
        public HashAlgorithmWrapper( HashAlgorithm hashAlgorithm )
            : this( hashAlgorithm, true ) {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HashAlgorithmWrapper"/> class.
        /// </summary>
        /// <param name="hashAlgorithm">Instance of <see cref="HashAlgorithm"/> to use for hashing.</param>
        /// <param name="ownsInstance"> 
        /// If true, the instance of <see cref="HashAlgorithm"/> passed will be disposed when the
        /// HashAlgorithmWrapper instance is disposed.
        /// </param>
        public HashAlgorithmWrapper( HashAlgorithm hashAlgorithm, Boolean ownsInstance ) {
            _hashAlgorithm = hashAlgorithm;
            _ownsInstance = ownsInstance;
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="HashAlgorithmWrapper"/> class.
        /// </summary>
        ~HashAlgorithmWrapper() {
            Dispose( false );
        }

        /// <inheritdoc/>
        public virtual Int32 HashSize { get { return _hashAlgorithm.HashSize; } }

        /// <summary>
        /// Disposes <see cref="HashAlgorithm"/> passed in constructor if it is owned by this <see cref="HashAlgorithmWrapper"/>.
        /// </summary>
        /// <param name="disposing">If false, call is assumed to be from the destructor.</param>
        protected virtual void Dispose( Boolean disposing ) {
            lock ( SyncRoot ) {
                if ( !_disposed && _ownsInstance ) {
                    this._hashAlgorithm.Dispose();
                }

                _disposed = true;
            }
        }

        /// <inheritdoc/>
        public Byte[] ComputeHash( Byte[] data ) {
            lock ( SyncRoot ) {
                return this._hashAlgorithm.ComputeHash( data );
            }
        }

        /// <inheritdoc/>
        public Byte[] ComputeHash( Stream data ) {
            lock ( SyncRoot ) {
                return this._hashAlgorithm.ComputeHash( data );
            }
        }

        /// <summary>
        /// Disposes <see cref="HashAlgorithm"/> passed in constructor if it is owned by this <see cref="HashAlgorithmWrapper"/>.
        /// </summary>
        public void Dispose() {
            Dispose( true );
        }
    }

    /// <summary>
    /// Generic implementation of <see cref="IHashFunction"/> that wraps cryptographic hash functions
    /// known as <see cref="HashAlgorithm"/> s.
    /// </summary>
    /// <typeparam name="HashAlgorithmT">HashAlgorithm type to wrap.</typeparam>
    public class HashAlgorithmWrapper<HashAlgorithmT>
        : IHashFunction, IDisposable
        where HashAlgorithmT : HashAlgorithm, new() {
        private readonly HashAlgorithmT _hashAlgorithm;

        private readonly Object SyncRoot = new Object();

        private Boolean _disposed = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="HashAlgorithmWrapper{HashAlgorithmT}"/> class.
        /// </summary>
        public HashAlgorithmWrapper() {
            _hashAlgorithm = new HashAlgorithmT();
        }

        /// <summary>
        /// Disposes instance, specifying that this is not a direct dispose call.
        /// </summary>
        ~HashAlgorithmWrapper() {
            Dispose( false );
        }

        /// <inheritdoc/>
        public virtual Int32 HashSize { get { return _hashAlgorithm.HashSize; } }

        /// <summary>
        /// Disposes <see cref="HashAlgorithm"/> created in constructor.
        /// </summary>
        /// <param name="disposing">If false, call is assumed to be from the destructor.</param>
        protected virtual void Dispose( Boolean disposing ) {
            lock ( SyncRoot ) {
                if ( !_disposed ) {
                    this._hashAlgorithm.Dispose();
                }

                _disposed = true;
            }
        }

        /// <inheritdoc/>
        public Byte[] ComputeHash( Byte[] data ) {
            lock ( SyncRoot ) {
                return this._hashAlgorithm.ComputeHash( data );
            }
        }

        /// <inheritdoc/>
        public Byte[] ComputeHash( Stream data ) {
            lock ( SyncRoot ) {
                return this._hashAlgorithm.ComputeHash( data );
            }
        }

        /// <summary>
        /// Disposes <see cref="HashAlgorithm"/> created in constructor.
        /// </summary>
        public void Dispose() {
            Dispose( true );
        }
    }
}
