using Xunit;
using _1_array_and_strings;

namespace tests._1_array_and_strings
{
    public class IsUniqueTests
    {
        [Theory]
        [InlineData("abcde", true)]
        [InlineData("abcdea", false)]
        [InlineData("bb", false)]
        [InlineData("adefolkmnzuq", true)]
        public void IsUnique_Should_Behave_as_Expected(string word, bool expectedResult){
            var result = IsUnique.WithDataStructure(word);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("abcde", true)]
        [InlineData("abcdea", false)]
        [InlineData("bb", false)]
        [InlineData("adefolkmnzuq", true)]
        public void IsUniqueWithoutDataStructure_Should_Behave_as_Expected(string word, bool expectedResult){
            var result = IsUnique.WithouDataStructure(word);

            Assert.Equal(expectedResult, result);
        }
    }
}