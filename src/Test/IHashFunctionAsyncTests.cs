using System.Data.HashFunction.Test.Mocks;
using System.IO;
using System.Linq;

namespace System.Data.HashFunction.Test {

    using Xunit;

    public abstract class IHashFunctionAsyncTests<IHashFunctionAsyncT>
        : IHashFunctionTests<IHashFunctionAsyncT>
        where IHashFunctionAsyncT : class, IHashFunctionAsync {

        [Fact]
        public async void IHashFunctionAsync_ComputeHashAsync_Stream_NonSeekable_MatchesKnownValues() {
            foreach ( var knownValueGroup in KnownValues.GroupBy( kv => kv.HashSize ) ) {
                var hf = CreateHashFunction( knownValueGroup.Key );

                foreach ( var knownValue in knownValueGroup ) {
                    using ( var ms = new SlowAsyncStream( new NonSeekableMemoryStream( knownValue.TestValue ) ) ) {
                        var hashResults = await hf.ComputeHashAsync( ms );

                        Assert.Equal(
                            knownValue.ExpectedValue.Take( ( hf.HashSize + 7 ) / 8 ),
                            hashResults );
                    }
                }
            }
        }

        [Fact]
        public async void IHashFunctionAsync_ComputeHashAsync_Stream_Seekable_MatchesKnownValues() {
            foreach ( var knownValue in KnownValues ) {
                var hf = CreateHashFunction( knownValue.HashSize );

                using ( var ms = new SlowAsyncStream( new MemoryStream( knownValue.TestValue ) ) ) {
                    var hashResults = await hf.ComputeHashAsync( ms );

                    Assert.Equal(
                        knownValue.ExpectedValue.Take( ( hf.HashSize + 7 ) / 8 ),
                        hashResults );
                }
            }
        }

        [Fact]
        public async void IHashFunctionAsync_ComputeHashAsync_Stream_Seekable_MatchesKnownValues_SlowStream() {
            foreach ( var knownValue in KnownValues ) {
                var hf = CreateHashFunction( knownValue.HashSize );

                using ( var ms = new SlowAsyncStream( new MemoryStream( knownValue.TestValue ) ) ) {
                    var hashResults = await hf.ComputeHashAsync( ms );

                    Assert.Equal(
                        knownValue.ExpectedValue.Take( ( hf.HashSize + 7 ) / 8 ),
                        hashResults );
                }
            }
        }
    }
}
