using _1_array_and_strings;
using Xunit;

namespace tests._1_array_and_strings
{
    public class PalindromePermutationTests
    {
        [Theory]
        [InlineData("tact coa",  true)]
        [InlineData("ayakk",  true)]
        [InlineData("ayyyaakk",  false)]
        public void CheckPermutation_ShouldBehaveAsExpected(string word, bool isPalindrome)
        {
            var result = PalindromePermutation.Verify(word);
            Assert.Equal(isPalindrome, result);
        }
    }
}