using _1_array_and_strings;
using Xunit;

namespace tests._1_array_and_strings
{
    public class OneWayTests
    {
        [Theory]
        [InlineData("pale", "pl", false)]
        [InlineData("pl", "pale", false)]
        [InlineData("pale", "ple", true)]
        [InlineData("pale", "pales", true)]
        [InlineData("pale", "bale", true)]
        [InlineData("pale", "bake", false)]
        public void OneWay_Should_Behave_As_Expected(string word, string newWord, bool expectedResult)
        {
            var result = OneWay.IsValid(word, newWord);
            Assert.Equal(expectedResult, result);
        }
    }
}