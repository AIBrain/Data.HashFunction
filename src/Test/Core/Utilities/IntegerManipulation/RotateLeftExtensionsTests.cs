using System.Data.HashFunction.Utilities.IntegerManipulation;

namespace System.Data.HashFunction.Test.Core.Utilities.IntegerManipulation {

    using Xunit;

    public class RotateLeftExtensionsTests {

        [Fact]
        public void RotateLeft_byte_RotatesCorrectly() {
            var operand = ( Byte )198;

            Assert.Equal( ( Byte )108, operand.RotateLeft( 4 ) );
        }

        [Fact]
        public void RotateLeft_UInt16_RotatesCorrectly() {
            var operand = ( UInt16 )38291;

            Assert.Equal( ( UInt16 )22841, operand.RotateLeft( 4 ) );
        }

        [Fact]
        public void RotateLeft_UInt32_RotatesCorrectly() {
            var operand = 2916644410U;

            Assert.Equal( 3716637610U, operand.RotateLeft( 4 ) );
        }

        [Fact]
        public void RotateLeft_UInt64_RotatesCorrectly() {
            var operand = 3421843292831082394UL;

            Assert.Equal( 17856004537878215074UL, operand.RotateLeft( 4 ) );
        }
    }
}
