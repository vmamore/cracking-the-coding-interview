using System.Linq;

namespace _1_array_and_strings
{
    // 1.2: Check Permutation: Given two strings, write a method to decide if one is a permutation of the
    // other. 
    public class CheckPermutation
    {
        public static bool AreEqual(string firstWord, string secondWord){
            var firstWordPalindrome = string.Join("", firstWord.ToCharArray().Reverse());
            return firstWordPalindrome.Equals(secondWord);
        }
    }
}