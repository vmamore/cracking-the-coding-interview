namespace _1_array_and_strings
{
    // 1.8:  Zero Matrix: Write an algorithm such that if an element in an MxN matrix is 0, its entire row and
    // column are set to 0. 
    public class ZeroMatrix
    {
        public static int[][] Execute(int[][] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;

            var rowZero = new bool[rows];
            var colZero = new bool[cols];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (matrix[r][c] == 0)
                        rowZero[r] = true;
                    colZero[c] = true;
                }
            }

            for (int r = 0; r < rows; r++)
            {
                if (rowZero[r])
                {
                    for (int c = 0; c < cols; c++)
                    {
                        matrix[r][c] = 0;
                    }
                }
            }

            for (int c = 0; c < cols; c++)
            {
                if (colZero[c])
                {
                    for (int r = 0; r < rows; r++)
                    {
                        matrix[r][c] = 0;
                    }
                }
            }

            return matrix;
        }
    }
}