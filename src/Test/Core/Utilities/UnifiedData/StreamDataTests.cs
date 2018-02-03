using System.IO;

namespace System.Data.HashFunction.Test.Core.Utilities.UnifiedData
{
    using System.Data.HashFunction.Utilities.UnifiedData;
    using Xunit;

    public class StreamDataTests
    {
        [Fact]
        public void StreamData_Dispose_Works()
        {
            var memoryStream = new MemoryStream();
            var streamData = new StreamData(memoryStream);


            Assert.True(memoryStream.CanRead);

            streamData.Dispose();

            Assert.False(memoryStream.CanRead);
        }


        public class UnifiedDataTests_StreamData
            : UnifiedDataTests
        {
            protected override UnifiedData CreateTestData(Int32 length)
            {
                var r = new Random();

                var data = new Byte[length];
                r.NextBytes(data);

                return new StreamData(new MemoryStream(data));
            }
        }
    }
}
