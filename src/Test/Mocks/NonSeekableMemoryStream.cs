using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace System.Data.HashFunction.Test.Mocks
{
    /// <summary>
    /// Forces underlying MemoryStream to report as being non-seekable.
    /// </summary>
    public class NonSeekableMemoryStream
        : MemoryStream
    {

        public virtual Int64 Real_Length { get { return base.Length; } }


        public override Boolean CanSeek { get { return false; } }

        [SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", 
            Justification = "Mock purposefully throws to indicate a major issue.")]
        public override Int64 Length
        {
            get { throw new NotImplementedException("Attempted to read length of a non-seekable stream."); }
        }



        public NonSeekableMemoryStream(Byte[] buffer) : base(buffer) { }
        public NonSeekableMemoryStream(Byte[] buffer, Boolean writable) : base(buffer, writable) { }
        public NonSeekableMemoryStream(Byte[] buffer, Int32 index, Int32 count) : base(buffer, index, count) { }
        public NonSeekableMemoryStream(Byte[] buffer, Int32 index, Int32 count, Boolean writable) : base(buffer, index, count, writable) { }
        public NonSeekableMemoryStream(Byte[] buffer, Int32 index, Int32 count, Boolean writable, Boolean publiclyVisible) : base(buffer, index, count, writable, publiclyVisible) { }


        
        public virtual Int64 Real_Seek(Int64 offset, SeekOrigin loc)
        {
            return base.Seek(offset, loc);
        }

        public virtual void Real_SetLength(Int64 value)
        {
            base.SetLength(value);
        }



        public override Int64 Seek(Int64 offset, SeekOrigin loc)
        {
            throw new NotImplementedException("Attempted to seek an non-seekable stream.");
        }


        public override void SetLength(Int64 value)
        {
            throw new NotImplementedException("Attempted to set length of a non-seekable stream.");
        }
    }
}
