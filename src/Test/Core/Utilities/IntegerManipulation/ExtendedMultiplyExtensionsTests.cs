using System.Data.HashFunction.Utilities.IntegerManipulation;

namespace System.Data.HashFunction.Test.Core.Utilities.IntegerManipulation {

    using Xunit;

    public class ExtendedMultiplyExtensionsTests {

        [Fact]
        public void ExtendedMulitply_MultipliesCorrectly() {
            var testValues = new[] {
                0UL,
                (UInt64) UInt16.MaxValue - 1, (UInt64) UInt16.MaxValue, (UInt64) UInt16.MaxValue + 1,
                (UInt64) UInt32.MaxValue - 1, (UInt64) UInt32.MaxValue, (UInt64) UInt32.MaxValue + 1,
                (UInt64) UInt64.MaxValue - 1, (UInt64) UInt64.MaxValue,
                3421783489UL, 23891920398UL
            };

            foreach ( var operand1 in testValues )
                foreach ( var operand2 in testValues ) {
                    var operand1Bytes = new[] { ( UInt32 )operand1, ( UInt32 )( operand1 >> 32 ) };
                    var operand2Bytes = new[] { ( UInt32 )operand2, ( UInt32 )( operand2 >> 32 ) };

                    var result = operand1Bytes.ExtendedMultiply( operand2Bytes );

                    Assert.Equal( operand1 * operand2, ( ( UInt64 )result[1] << 32 ) | result[0] );
                }
        }

        [Fact]
        public void ExtendedMulitply_UsesLargestOperandLength() {
            var smallOperand = new[] { 0U, 0U };
            var largeOperand = new[] { 0U, 0U, 0U, 0U, 0U };

            Assert.Equal( 5, smallOperand.ExtendedMultiply( largeOperand ).Length );
            Assert.Equal( 5, largeOperand.ExtendedMultiply( smallOperand ).Length );
        }

        [Fact]
        public void ExtendedMulitply_ZeroMultiplerProduct_Correct() {
            var operand1 = new[] { 1U, 1U, 1U, 0U, 0U };
            var operand2 = new[] { 0U, 1U, 0U, 0U, 0U };

            Assert.Equal( new[] { 0U, 1U, 1U, 1U, 0U },
                operand1.ExtendedMultiply( operand2 ) );
        }
    }
}
