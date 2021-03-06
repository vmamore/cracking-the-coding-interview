using _1_array_and_strings;
using Xunit;

namespace tests._1_array_and_strings
{
    public class CheckPermutationTests
    {
        [Theory]
        [InlineData("word", "drow", true)]
        [InlineData("ana", "ana", true)]
        [InlineData("ana", "bananaana", false)]
        [InlineData("cacacsana", "anazcacac", false)]
        public void CheckPermutation_ShouldBehaveAsExpected(string firstWord, string secondWord, bool expectedResult)
        {
            var result = CheckPermutation.AreEqual(firstWord, secondWord);
            Assert.Equal(expectedResult, result);
        }
    }
}