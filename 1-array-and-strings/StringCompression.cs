using System.Collections.Generic;
using System.Text;

namespace _1_array_and_strings
{
    // 1.6 : Implement a method to perform basic string compression using the counts
    // of repeated characters. For example, the string aabcccccaaa would become a2blc5a3. If the
    // "compressed" string would not become smaller than the original string, your method should return
    // the original string.
    public class StringCompression
    {
        public class CharCompression
        {
            public char Character { get; set; }
            public int Times { get; set; }
            public override string ToString() => $"{Character}{Times}";
        }
        public static string Execute(string wordToCompress)
        {
            var queue = new Queue<CharCompression>();

            for (int i = 0; i < wordToCompress.Length; i++)
            {
                var characterCompression = new CharCompression
                {
                    Character = wordToCompress[i],
                    Times = 1
                };
                var nextIndex = i + 1;
                do
                {
                    if (nextIndex < wordToCompress.Length)
                    {
                        if (characterCompression.Character.Equals(wordToCompress[nextIndex]))
                        {
                            characterCompression.Times++;
                            i = nextIndex;
                            nextIndex++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                } while (nextIndex < wordToCompress.Length);
                queue.Enqueue(characterCompression);
            }

            var wordCompressedBuilder = new StringBuilder();
            foreach (var item in queue)
                wordCompressedBuilder.Append(item.ToString());

            var compressedWord = wordCompressedBuilder.ToString();

            return compressedWord.Length > wordToCompress.Length ? wordToCompress : compressedWord;
        }
    }
}