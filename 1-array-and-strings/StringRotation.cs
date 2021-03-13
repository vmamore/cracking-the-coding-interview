namespace _1_array_and_strings
{
    public class StringRotation
    {
        public static bool IsRotation(string s1, string s2)
        {
            if(s1.Length != s2.Length) return false;

            string s1s1 = s1 + s1;
            return s1s1.Contains(s2);
        }
    }
}