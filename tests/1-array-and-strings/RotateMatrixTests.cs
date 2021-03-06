using _1_array_and_strings;
using Xunit;

namespace tests._1_array_and_strings
{
    public class RotateMatrixTests
    {
        [Fact]
        public void Execute()
        {
            var array = new int[3, 3] {
                { 1, 2, 3},
                { 1, 2, 3},
                { 1, 2, 3}
            };

            var expectedArray = new int[3, 3] {
                { 1, 1, 1},
                { 2, 2, 2},
                { 3, 3, 3}
            };

            var resultArray = RotateMatrix.Execute(array);

            Assert.Equal(expectedArray, resultArray);
        }
    }
}