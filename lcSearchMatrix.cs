namespace CSharp_Practice
{
    public class lcSearchMatrix
    {
        public bool SearchMatrix(int[][] matrix, int target) 
        {
            if (matrix == null || matrix.Length == 0) return false;
            //number of rows
            int numRows = matrix.Length;
            //number of columns
            int numCol = matrix[0].Length;
            int row = 0;
            int col = numCol - 1;

            while (row < numRows && col >= 0)
            {
                if (matrix[row][col] == target)
                    return true;
                if (matrix[row][col] < target)
                    row++;
                else
                    row--;
            }
            return false;
        }
    }
}