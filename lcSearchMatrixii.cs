namespace CSharp_Practice
{
    public class lcSearchMatrix
    {
        public bool SearchMatrix(int[,] matrix, int target) 
        {
            //number of rows
            int numRows = matrix.GetLength(0);
            //number of columns
            int numCol = matrix.GetLength(1);
            
            int row = 0;
            int col = numCol - 1;
            
            while (row < numRows && col >= 0)
            {
                if(matrix[row, col] == target)
                    return true;
                
                if(matrix[row,col] < target)
                    row++;
                else
                    col--;
            }
            return false;
        }
        public bool SearchMatrixBrute(int[,] matrix, int target)
        {
            if (matrix == null || matrix.GetLength(0) == 0)
                return false;
            int lim0 = matrix.GetLength(0);
            int lim1 = matrix.GetLength(1);
            for (int i = 0; i < lim0; i++)
            {
                {
                    for (int j = 0; j < lim1; j++)
                    {
                        if (matrix[i,j] == target)
                            return true;
                    }
                }
            }
            return false;
        }
    }
}