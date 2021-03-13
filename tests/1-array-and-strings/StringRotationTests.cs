using _1_array_and_strings;
using Xunit;

namespace tests._1_array_and_strings
{
    public class StringRotationTests
    {
        [Theory]
        [InlineData("erbottlewat", "waterbottle", true)]
        [InlineData("cat", "dog", false)]
        public void Validate(string s1, string s2, bool expectedResult)
        {
            var result = StringRotation.IsRotation(s1, s2);

            Assert.Equal(expectedResult, result);
        }
    }
}