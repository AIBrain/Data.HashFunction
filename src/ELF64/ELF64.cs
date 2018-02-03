using System.Data.HashFunction.Utilities.UnifiedData;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace System.Data.HashFunction
{
    /// <summary>
    /// Implementation of the hash function used in the elf64 object file format as specified at 
    ///   http://downloads.openwatcom.org/ftp/devel/docs/elf-64-gen.pdf on page 17.
    ///
    /// Contrary to the name, the hash algorithm is only designed for 32-bit output hash sizes.
    /// </summary>
    public class ELF64
#if !NET40 || INCLUDE_ASYNC
        : HashFunctionAsyncBase
#else
        : HashFunctionBase
#endif
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ELF64"/> class.
        /// </summary>
        /// <inheritdoc cref="HashFunctionBase(int)" />
        public ELF64()
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

            return BitConverter.GetBytes(hash);
        }
#endif


#if !NET40
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        private static void ProcessBytes(ref UInt32 hash, Byte[] dataBytes, Int32 position, Int32 length)
        {
            for (var x = position; x < position + length; ++x )
            {
                hash <<= 4;
                hash += dataBytes[x];

                var tmp = hash & 0xF0000000;

                if (tmp != 0)
                    hash ^= tmp >> 24;

                hash &= 0x0FFFFFFF;
            }
        }
    }
}
