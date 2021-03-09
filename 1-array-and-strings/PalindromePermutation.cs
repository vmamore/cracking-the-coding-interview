using System.Collections.Generic;

namespace _1_array_and_strings
{
    // 1.4: Palindrome Permutation: Given a string, write a function to check if it is a permutation of a palindrome.
    // A palindrome is a word or phrase that is the same forwards and backwards. A permutation
    // is a rearrangement of letters. The palindrome does not need to be limited to just dictionary words
    public class PalindromePermutation
    {
        public static bool Verify(string permutation)
        {
            permutation = permutation.Replace(" ", "");
            var dictionary = new Dictionary<char, int>();
            foreach(var character in permutation){
                if(dictionary.ContainsKey(character))
                    dictionary[character] = dictionary[character] + 1;
                else
                    dictionary[character] = 1;
            }
            int oddCounter = 0;
            foreach(var item in dictionary){
                if(item.Value % 2 != 0 && oddCounter == 0)
                    oddCounter += 1;
                else if (item.Value % 2 != 0 && oddCounter != 0)
                    return false;
            }
            return true;
        }
    }
}