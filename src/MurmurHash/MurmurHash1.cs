using System.Data.HashFunction.Utilities.UnifiedData;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace System.Data.HashFunction
{
    /// <summary>
    /// Implementation of MurmurHash1 as specified at https://code.google.com/p/smhasher/source/browse/trunk/MurmurHash1.cpp 
    ///   and https://code.google.com/p/smhasher/wiki/MurmurHash1.
    /// 
    /// This hash function has been superseded by MurmurHash2 and MurmurHash3.
    /// </summary>
    public class MurmurHash1
#if !NET40 || INCLUDE_ASYNC
        : HashFunctionAsyncBase
#else
        : HashFunctionBase
#endif
    {
        /// <summary>
        /// Seed value for hash calculation.
        /// </summary>
        /// <value>
        /// The seed value for hash calculation.
        /// </value>
        public UInt32 Seed { get { return _Seed; } }


        /// <inheritdoc />
        protected override Boolean RequiresSeekableStream { get { return true; } }

        /// <summary>
        /// Constant m as defined by MurmurHash1 specification.
        /// </summary>
        protected const UInt32 m = 0XC6A4A793;


        private readonly UInt32 _Seed;

        /// <remarks>Defaults <see cref="Seed" /> to 0.</remarks>
        /// <inheritdoc cref="MurmurHash1(UInt32)"/>
        public MurmurHash1()
            : this(0U)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MurmurHash1"/> class.
        /// </summary>
        /// <param name="seed"><inheritdoc cref="Seed" /></param>
        /// <inheritdoc cref="HashFunctionBase(int)" />
        public MurmurHash1(UInt32 seed)
            : base(32)
        {
            _Seed = seed;
        }


        /// <inheritdoc />
        protected override Byte[] ComputeHashInternal(UnifiedData data)
        {
            UInt32 h = Seed ^ ((UInt32) data.Length * m);

            data.ForEachGroup(4, 
                (dataGroup, position, length) => {
                    ProcessGroup(ref h, dataGroup, position, length);
                },
                (remainder, position, length) => {
                    ProcessRemainder(ref h, remainder, position, length);
                });
 
            h *= m;
            h ^= h >> 10;
            h *= m;
            h ^= h >> 17;

            return BitConverter.GetBytes(h);
        }
        
#if !NET40 || INCLUDE_ASYNC
        /// <inheritdoc />
        protected override async Task<Byte[]> ComputeHashAsyncInternal(UnifiedData data)
        {
            UInt32 h = Seed ^ ((UInt32) data.Length * m);

            await data.ForEachGroupAsync(4,
                (dataGroup, position, length) => {
                    ProcessGroup(ref h, dataGroup, position, length);
                },
                (remainder, position, length) => {
                    ProcessRemainder(ref h, remainder, position, length);
                }).ConfigureAwait(false);

            h *= m;
            h ^= h >> 10;
            h *= m;
            h ^= h >> 17;

            return BitConverter.GetBytes(h);
        }
#endif


#if !NET40
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        private static void ProcessGroup(ref UInt32 h, Byte[] dataGroup, Int32 position, Int32 length)
        {
            for (var x = position; x < position + length; x += 4)
            {
                h += BitConverter.ToUInt32(dataGroup, x);
                h *= m;
                h ^= h >> 16;
            }
        }

#if !NET40
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        private static void ProcessRemainder(ref UInt32 h, Byte[] remainder, Int32 position, Int32 length)
        {
            switch (length)
            {
                case 3: h += (UInt32) remainder[position + 2] << 16; goto case 2;
                case 2: h += (UInt32) remainder[position + 1] <<  8; goto case 1;
                case 1:
                    h += (UInt32) remainder[position];
                    break;
            };

            h *= m;
            h ^= h >> 16;
        }
    }
}
