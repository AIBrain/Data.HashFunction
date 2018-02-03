using System.Data.HashFunction.Test.Mocks;
using System.IO;

namespace System.Data.HashFunction.Test.Core {

    using Moq;
    using Xunit;

    public class HashFunctionBaseTests {

        [Fact]
        public void HashFunctionBase_ComputeHash_Stream_NotReadable_Throws() {
            var msMock = new Mock<MemoryStream>();

            msMock.SetupGet( ms => ms.CanRead )
                .Returns( false );

            var hf = new HashFunctionImpl( 0 );

            Assert.Equal( "data",
                Assert.Throws<ArgumentException>( () =>
                     hf.ComputeHash( msMock.Object ) )
                .ParamName );
        }
    }
}
