using _1_array_and_strings;
using Xunit;

namespace tests._1_array_and_strings
{
    public class URLifyTests
    {
        [Theory]
        [InlineData("Mr John Smith         ","Mr%20John%20Smith", 13)]
        [InlineData("Mr  John Smit         ","Mr%20%20John%20Smit", 13)]
        public void Should_URLify_Behave_As_Expected(string word, string expectedUrlifiedWord, int length)
        {
            var wordUrlified = URLify.Transform(word, length);
            Assert.Equal(expectedUrlifiedWord, wordUrlified);
        }
    }
}