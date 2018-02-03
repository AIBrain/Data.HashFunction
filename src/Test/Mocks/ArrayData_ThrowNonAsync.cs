using System;
using System.Collections.Generic;
using System.Data.HashFunction.Utilities.UnifiedData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.HashFunction.Test.Mocks
{
    internal class ArrayData_ThrowNonAsync
        : ArrayData
    {
        public static readonly InvalidOperationException ExceptionToThrow = new InvalidOperationException("Mock Exception");


        public ArrayData_ThrowNonAsync(Byte[] data)
            : base(data)
        {

        }

        public override void ForEachRead(Action<Byte[], Int32, Int32> action)
        {
            throw ExceptionToThrow;
        }

        public override void ForEachGroup(Int32 groupSize, Action<Byte[], Int32, Int32> action, Action<Byte[], Int32, Int32> remainderAction)
        {
            throw ExceptionToThrow;
        }

        public override Byte[] ToArray()
        {
            throw ExceptionToThrow;
        }
    }
}
