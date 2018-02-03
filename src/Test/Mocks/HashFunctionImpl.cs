using System;
using System.Collections.Generic;
using System.Data.HashFunction.Utilities;
using System.Data.HashFunction.Utilities.UnifiedData;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.HashFunction.Test.Mocks
{
    public class HashFunctionImpl
            : HashFunctionAsyncBase
    {
        public HashFunctionImpl(Int32 hashSize)
            : base(hashSize)
        {

        }


        protected override Byte[] ComputeHashInternal(UnifiedData data)
        {
            return new Byte[0];
        }
        
        protected override async Task<Byte[]> ComputeHashAsyncInternal(UnifiedData data)
        {
            return await Task.FromResult(new Byte[0])
                .ConfigureAwait(false);
        }
    }
}
