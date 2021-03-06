namespace _1_array_and_strings
{
    // 1.3: URLify: Write a method to replace all spaces in a string with '%20'. You may assume that the string
    // has sufficient space at the end to hold the additional characters, and that you are given the "true"
    // length of the string.
    public class URLify
    {
        public static string Transform(string phrase, int length)
        {
            var phraseUrlify = phrase.Substring(0, length).Replace(" ", "%20");
            return phraseUrlify;
        }
    }
}