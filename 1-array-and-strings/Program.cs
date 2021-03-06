using System;

namespace _1_array_and_strings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var array = new int[3, 3]
            {
                { 1, 2, 3},
                { 1, 2, 3},
                { 1, 2, 3}
            };
            Console.WriteLine(RotateMatrix.Execute(array));
        }
    }
}
