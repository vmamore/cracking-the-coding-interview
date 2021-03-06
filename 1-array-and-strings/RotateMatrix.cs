namespace _1_array_and_strings
{
    // 1.7: Rotate Matrix: Given an image represented by an NxN matrix, where each pixel in the image is 4
    // bytes, write a method to rotate the image by 90 degrees. Can you do this in place?
    //
    //    1 2 3 => 1 1 1 
    //    1 2 3 => 2 2 2
    //    1 2 3 => 3 3 3
    //
    public class RotateMatrix
    {
        public static int[,] Execute(int[,] pixelArray)
        {
            var newArray = new int[pixelArray.GetLength(0), pixelArray.GetLength(1)];

            for (int i = 0; i < pixelArray.GetLength(0); i++)
            {
                for (int j = 0; j < pixelArray.GetLength(1); j++)
                {
                    newArray[i, j] = pixelArray[j, i];
                }
            }

            return newArray;
        }
    }
}