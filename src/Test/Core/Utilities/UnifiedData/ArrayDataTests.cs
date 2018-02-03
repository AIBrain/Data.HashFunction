using System.Data.HashFunction.Test.Mocks;

namespace System.Data.HashFunction.Test.Core.Utilities.UnifiedData
{
    using System.Data.HashFunction.Utilities.UnifiedData;
 
    public class ArrayDataTests
    {
        [Fact]
        public async void ArrayData_ToArrayAsync_ThrowsAggregateExceptions()
        {
            var testData = new ArrayData_ThrowNonAsync(new Byte[0]);

            Assert.Equal("Mock Exception", 
                (await Assert.ThrowsAsync<InvalidOperationException>(async () => 
                    await testData.ToArrayAsync()))
                .Message);       
        }


        public class UnifiedDataTests_ArrayData
            : UnifiedDataTests
        {
            protected override UnifiedData CreateTestData(Int32 length)
            {
                var r = new Random();

                var data = new Byte[length];
                r.NextBytes(data);

                return new ArrayData(data);
            }
        }

    }

}
