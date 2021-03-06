using _1_array_and_strings;
using Xunit;

namespace tests._1_array_and_strings
{
    public class StringCompressionTests
    {
        [Theory]
        [InlineData("aabcccccaaa", "a2b1c5a3")]
        [InlineData("abcdef", "abcdef")]
        [InlineData("accccccdddefg", "a1c6d3e1f1g1")]
        public void Should_Test(string word, string expectedWordCompressed)
        {
            var wordCompressed = StringCompression.Execute(word);
            Assert.Equal(expectedWordCompressed, wordCompressed);
        }
    }
}