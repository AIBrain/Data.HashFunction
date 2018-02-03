using System.Data.HashFunction.Utilities.UnifiedData;
using System.Threading.Tasks;

namespace System.Data.HashFunction.Test.Mocks {

    public class HashFunctionImpl
            : HashFunctionAsyncBase {

        public HashFunctionImpl( Int32 hashSize )
            : base( hashSize ) {
        }

        protected override async Task<Byte[]> ComputeHashAsyncInternal( UnifiedData data ) {
            return await Task.FromResult( new Byte[0] )
                .ConfigureAwait( false );
        }

        protected override Byte[] ComputeHashInternal( UnifiedData data ) {
            return new Byte[0];
        }
    }
}
