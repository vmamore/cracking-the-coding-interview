using System;
using System.Linq;

namespace _1_array_and_strings
{
    // 1.5: One Away: There are three types of edits that can be performed on strings: insert a character,
    // remove a character, or replace a character. Given two strings, write a function to check if they are
    // one edit (or zero edits) away
    public class OneWay
    {
        public static bool IsValid(string word, string newWord)
        {
            var differentLength = Math.Abs(word.Length - newWord.Length);
            if (differentLength > 1) return false;

            var wordArray = word.ToCharArray();
            var newWordArray = newWord.ToCharArray();

            var differentCharacters = wordArray.Except(newWordArray);

            return differentCharacters.Count() > 1 ? false : true;
        }
    }
}