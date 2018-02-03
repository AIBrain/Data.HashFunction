using System.Data.HashFunction.Utilities.UnifiedData;

namespace System.Data.HashFunction.Test.Mocks {

    internal class ArrayData_ThrowNonAsync
        : ArrayData {
        public static readonly InvalidOperationException ExceptionToThrow = new InvalidOperationException( "Mock Exception" );

        public ArrayData_ThrowNonAsync( Byte[] data )
            : base( data ) {
        }

        public override void ForEachGroup( Int32 groupSize, Action<Byte[], Int32, Int32> action, Action<Byte[], Int32, Int32> remainderAction ) {
            throw ExceptionToThrow;
        }

        public override void ForEachRead( Action<Byte[], Int32, Int32> action ) {
            throw ExceptionToThrow;
        }

        public override Byte[] ToArray() {
            throw ExceptionToThrow;
        }
    }
}
