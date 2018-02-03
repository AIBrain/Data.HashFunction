using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.HashFunction.Utilities.UnifiedData
{
    internal class ArrayData
        : UnifiedData
    {
        /// <inheritdoc />
        public override Int64 Length { get { return _Data.LongLength; } }

        
        protected readonly Byte[] _Data;


        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayData"/> class.
        /// </summary>
        /// <param name="data">The data to represent.</param>
        public ArrayData(Byte[] data)
        {
            _Data = data;
            BufferSize = (
                _Data.Length > 0 ?
                _Data.Length :
                1);
        }



        /// <inheritdoc />
        public override void ForEachRead(Action<Byte[], Int32, Int32> action)
        {
            if (action == null)
                throw new ArgumentNullException("action");


            action(_Data, 0, _Data.Length);
        }

#if !NET40 || INCLUDE_ASYNC
        /// <inheritdoc />
        public override Task ForEachReadAsync(Action<Byte[], Int32, Int32> action)
        {
            ForEachRead(action);

#if !INCLUDE_ASYNC
            return Task.FromResult(true);
#else
            return TaskEx.FromResult(true);
#endif
        }
#endif



            /// <inheritdoc />
        public override void ForEachGroup(Int32 groupSize, Action<Byte[], Int32, Int32> action, Action<Byte[], Int32, Int32> remainderAction)
        {
            if (groupSize <= 0)
                throw new ArgumentOutOfRangeException("groupSize", "bufferSize must be greater than 0.");

            if (action == null)
                throw new ArgumentNullException("action");


            var remainderLength = _Data.Length % groupSize;

            if (_Data.Length - remainderLength > 0)
                action(_Data, 0, _Data.Length - remainderLength);

            if (remainderAction != null)
            {
                if (remainderLength > 0)
                    remainderAction(_Data, _Data.Length - remainderLength, remainderLength);
            }
        }

#if !NET40 || INCLUDE_ASYNC
        /// <inheritdoc />
        public override Task ForEachGroupAsync(Int32 groupSize, Action<Byte[], Int32, Int32> action, Action<Byte[], Int32, Int32> remainderAction)
        {
            ForEachGroup(groupSize, action, remainderAction);

#if !INCLUDE_ASYNC
            return Task.FromResult(true);
#else
            return TaskEx.FromResult(true);
#endif
        }
#endif



        /// <inheritdoc />
        public override Byte[] ToArray()
        {
            return _Data;
        }

#if !NET40 || INCLUDE_ASYNC
        /// <inheritdoc />
        public override Task<Byte[]> ToArrayAsync()
        {
#if !INCLUDE_ASYNC
            return Task.FromResult(
                ToArray());
#else
            return TaskEx.FromResult(
                ToArray());
#endif
        }
#endif

    }
}
