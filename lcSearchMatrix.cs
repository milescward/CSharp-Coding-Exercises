namespace CSharp_Practice
{
    public class lcSearchMatrix
    {
        public bool SearchMatrix(int[][] matrix, int target) {
        if (matrix == null || matrix.Length == 0) return false;
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if(matrix[i][j] == target)
                {
                    return true;
                }
            }
        }
        return false;
    }
    }
}