using System.Data.HashFunction.Utilities.UnifiedData;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace System.Data.HashFunction
{
    /// <summary>
    /// Implementation of Bob Jenkins' One-at-a-Time hash function as specified at http://www.burtleburtle.net/bob/hash/doobs.html (function named "one_at_a_time").
    /// 
    /// This hash function has been superseded by JenkinsLookup2 and JenkinsLookup3.
    /// </summary>
    public class JenkinsOneAtATime
#if !NET40 || INCLUDE_ASYNC
        : HashFunctionAsyncBase
#else
        : HashFunctionBase
#endif
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="JenkinsOneAtATime" /> class.
        /// </summary>
        /// <inheritdoc cref="HashFunctionBase(int)" />
        public JenkinsOneAtATime()
            : base(32)
        {

        }


        /// <inheritdoc />
        protected override Byte[] ComputeHashInternal(UnifiedData data)
        {
            UInt32 hash = 0;
            
            data.ForEachRead((dataBytes, position, length) => {
                ProcessBytes(ref hash, dataBytes, position, length);
            });
            
            hash += hash << 3;
            hash ^= hash >> 11;
            hash += hash << 15;

            return BitConverter.GetBytes(hash);
        }
        
#if !NET40 || INCLUDE_ASYNC
        /// <inheritdoc />
        protected override async Task<Byte[]> ComputeHashAsyncInternal(UnifiedData data)
        {
            UInt32 hash = 0;

            await data.ForEachReadAsync((dataBytes, position, length) => {
                ProcessBytes(ref hash, dataBytes, position, length);
            }).ConfigureAwait(false);

            hash += hash << 3;
            hash ^= hash >> 11;
            hash += hash << 15;

            return BitConverter.GetBytes(hash);
        }
#endif


#if !NET40
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        private static void ProcessBytes(ref UInt32 hash, Byte[] dataBytes, Int32 position, Int32 length)
        {
            for (var x = position; x < position + length; ++x)
            {
                hash += dataBytes[x];
                hash += (hash << 10);
                hash ^= (hash >> 6);
            }
        }
    }
}
