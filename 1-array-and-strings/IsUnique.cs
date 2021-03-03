using System.Collections.Generic;

namespace _1_array_and_strings
{
    // 1.1 Is Unique: Implement an algorithm to determine if a string has all unique characters. What if you
    // cannot use additional data structures? 
    public class IsUnique
    {
        public static bool WithDataStructure(string word)
        {
            var length = word.Length;
            var set = new HashSet<char>();
            foreach(var character in word){
                set.Add(character);
            }
            return length == set.Count;
        }

        public static bool WithouDataStructure(string word)
        {
            var allUniqueCharacters = true;
            for(int i = 0; i < word.Length; i++){
                var character = word[i];
                for(int j = i + 1; j < word.Length; j++){
                    if(!character.Equals(word[j])) continue;
                    allUniqueCharacters = false;
                    break;
                }
                if(!allUniqueCharacters) break;
            }
            return allUniqueCharacters;
        }
    }
}