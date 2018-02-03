using System.Collections.Generic;
using System.Data.HashFunction.Test.Mocks;
using System.Data.HashFunction.Utilities.IntegerManipulation;
using System.IO;
using System.Linq;
using System.Reflection;

namespace System.Data.HashFunction.Test {

    using Xunit;

    public abstract class IHashFunctionTests<IHashFunctionT>
        where IHashFunctionT : class, IHashFunction {

        protected abstract IEnumerable<KnownValue> KnownValues { get; }

        protected abstract IHashFunctionT CreateHashFunction( Int32 hashSize );

        [Fact]
        public void IHashFunction_ComputeHash_ByteArray_MatchesKnownValues() {
            foreach ( var knownValue in KnownValues ) {
                var hf = CreateHashFunction( knownValue.HashSize );
                var hashResults = hf.ComputeHash( knownValue.TestValue );

                Assert.Equal(
                        knownValue.ExpectedValue.Take( ( hf.HashSize + 7 ) / 8 ),
                        hashResults );
            }
        }

        [Fact]
        public void IHashFunction_ComputeHash_Stream_NonSeekable_MatchesKnownValues() {
            foreach ( var knownValue in KnownValues ) {
                var hf = CreateHashFunction( knownValue.HashSize );

                using ( var ms = new NonSeekableMemoryStream( knownValue.TestValue ) ) {
                    var hashResults = hf.ComputeHash( ms );

                    Assert.Equal(
                        knownValue.ExpectedValue.Take( ( hf.HashSize + 7 ) / 8 ),
                        hashResults );
                }
            }
        }

        [Fact]
        public void IHashFunction_ComputeHash_Stream_Seekable_MatchesKnownValues() {
            foreach ( var knownValue in KnownValues ) {
                var hf = CreateHashFunction( knownValue.HashSize );

                using ( var ms = new MemoryStream( knownValue.TestValue ) ) {
                    var hashResults = hf.ComputeHash( ms );

                    Assert.Equal(
                        knownValue.ExpectedValue.Take( ( hf.HashSize + 7 ) / 8 ),
                        hashResults );
                }
            }
        }

        [Fact]
        public void IHashFunction_Constructor_InvalidHashSize_Throws() {

            // Ignore if hash function does not seem to have a configurable hashSize constructor.
            if ( KnownValues.Select( kv => kv.HashSize ).Distinct().Count() <= 1 )
                return;

            Exception resultingException = null;

            try {
                GC.KeepAlive(
                    CreateHashFunction( -1 ) );
            }
            catch ( Exception e ) {
                resultingException = e;
            }

            Assert.NotNull( resultingException );

            if ( resultingException is TargetInvocationException )
                resultingException = resultingException.InnerException;

            Assert.Equal( "hashSize",
                Assert.IsType<ArgumentOutOfRangeException>(
                    resultingException )
                .ParamName );
        }

        protected class KnownValue {
            public readonly Byte[] ExpectedValue;
            public readonly Int32 HashSize;
            public readonly Byte[] TestValue;

            public KnownValue( Int32 hashSize, IEnumerable<Byte> testValue, IEnumerable<Byte> expectedValue ) {
                TestValue = testValue.ToArray();
                ExpectedValue = expectedValue.ToArray();
                HashSize = hashSize;
            }

            public KnownValue( Int32 hashSize, String utf8Value, String expectedValue )
                : this( hashSize, utf8Value.ToBytes(), expectedValue.HexToBytes() ) { }

            public KnownValue( Int32 hashSize, String utf8Value, UInt32 expectedValue )
                : this( hashSize, utf8Value.ToBytes(), expectedValue.ToBytes( 32 ) ) { }

            public KnownValue( Int32 hashSize, String utf8Value, UInt64 expectedValue )
                : this( hashSize, utf8Value.ToBytes(), expectedValue.ToBytes( 64 ) ) { }

            public KnownValue( Int32 hashSize, IEnumerable<Byte> value, String expectedValue )
                : this( hashSize, value, expectedValue.HexToBytes() ) { }

            public KnownValue( Int32 hashSize, IEnumerable<Byte> value, UInt32 expectedValue )
                : this( hashSize, value, expectedValue.ToBytes( 32 ) ) { }

            public KnownValue( Int32 hashSize, IEnumerable<Byte> value, UInt64 expectedValue )
                : this( hashSize, value, expectedValue.ToBytes( 64 ) ) { }
        }
    }
}
