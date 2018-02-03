using System.Data.HashFunction.Utilities;

namespace System.Data.HashFunction.Test.Core.Utilities {

    using Xunit;

    public class UInt32ExtensionsTests {

        [Fact]
        public void UInt32_IEnumerable_ToBytes_ComputesCorrectly() {
            var testValues = new[] { 2382910298U, 0U, 32483910U, 231398239U };

            var expected = new Byte[] {
                0x5A, 0x53, 0x08, 0x8E,
                0x00, 0x00, 0x00, 0x00,
                0x46, 0xaa, 0xef, 0x01,
                0x5f, 0xdb, 0xca, 0x0d
            };

            Assert.Equal( expected, testValues.ToBytes() );
        }
    }
}
