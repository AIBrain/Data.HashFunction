using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.HashFunction.Test.Mocks
{
    /// <summary>
    /// Forces async functions to actually run asynchronously by delaying the read.
    /// </summary>
    public class SlowAsyncStream
        : Stream
    {
        public override Boolean CanRead { get { return _underlyingStream.CanRead; } }
        public override Boolean CanSeek { get { return _underlyingStream.CanSeek; } }
        public override Boolean CanTimeout { get { return _underlyingStream.CanTimeout; } }
        public override Boolean CanWrite { get { return _underlyingStream.CanTimeout; } }

        public override Int64 Length { get { return _underlyingStream.Length; } }

        public override Int64 Position
        {
            get { return _underlyingStream.Position; }
            set { _underlyingStream.Position = value; }
        }

        public override Int32 ReadTimeout
        {
            get { return _underlyingStream.ReadTimeout; }
            set { _underlyingStream.ReadTimeout = value; }
        }

        public override Int32 WriteTimeout
        {
            get { return _underlyingStream.WriteTimeout; }
            set { _underlyingStream.WriteTimeout = value; }
        }


        private readonly Stream _underlyingStream;

        public SlowAsyncStream(Stream underlyingStream) 
        {
            _underlyingStream = underlyingStream;
        }

        public override IAsyncResult BeginRead(Byte[] buffer, Int32 offset, Int32 count, AsyncCallback callback, Object state)
        {
            return _underlyingStream.BeginRead(buffer, offset, count, callback, state);
        }

        public override IAsyncResult BeginWrite(Byte[] buffer, Int32 offset, Int32 count, AsyncCallback callback, Object state)
        {
            return _underlyingStream.BeginWrite(buffer, offset, count, callback, state);
        }

        public override void Close()
        {
            _underlyingStream.Close();
        }

        public async override Task CopyToAsync(Stream destination, Int32 bufferSize, CancellationToken cancellationToken)
        {
            await Task.Delay(10)
                .ConfigureAwait(false);

            await _underlyingStream.CopyToAsync(destination, bufferSize, cancellationToken)
                .ConfigureAwait(false);
        }

        protected override void Dispose(Boolean disposing)
        {
            if (disposing)
                _underlyingStream.Dispose();
        }

        public override Int32 EndRead(IAsyncResult asyncResult)
        {
            return _underlyingStream.EndRead(asyncResult);
        }

        public override void EndWrite(IAsyncResult asyncResult)
        {
            _underlyingStream.EndWrite(asyncResult);
        }

        public override void Flush()
        {
            _underlyingStream.Flush();
        }

        public async override Task FlushAsync(CancellationToken cancellationToken)
        {
            await Task.Delay(10)
                .ConfigureAwait(false);

            await _underlyingStream.FlushAsync(cancellationToken)
                .ConfigureAwait(false);
        }

        public override Int32 Read(Byte[] buffer, Int32 offset, Int32 count)
        {
            return _underlyingStream.Read(buffer, offset, count);
        }

        public async override Task<Int32> ReadAsync(Byte[] buffer, Int32 offset, Int32 count, CancellationToken cancellationToken)
        {
            await Task.Delay(10)
                .ConfigureAwait(false);

            return await _underlyingStream.ReadAsync(buffer, offset, count, cancellationToken)
                .ConfigureAwait(false);
        }

        public override Int32 ReadByte()
        {
            return _underlyingStream.ReadByte();
        }

        public override Int64 Seek(Int64 offset, SeekOrigin origin)
        {
            return _underlyingStream.Seek(offset, origin);
        }

        public override void SetLength(Int64 value)
        {
            _underlyingStream.SetLength(value);
        }

        public override void Write(Byte[] buffer, Int32 offset, Int32 count)
        {
            _underlyingStream.Write(buffer, offset, count);
        }

        public async override Task WriteAsync(Byte[] buffer, Int32 offset, Int32 count, CancellationToken cancellationToken)
        {
            await Task.Delay(50)
                .ConfigureAwait(false);

            await _underlyingStream.WriteAsync(buffer, offset, count, cancellationToken)
                .ConfigureAwait(false);
        }

        public override void WriteByte(Byte value)
        {
            _underlyingStream.WriteByte(value);
        }
    }
}
