using System.Collections.Generic;

namespace CSharp_Practice
{
    public class lcSetMatrixZeros
    {
        public void SetZeroes(int[][] matrix) 
        {
            if(matrix == null || matrix.Length == 0)
                return;
            var s = new Stack<int>();
            for(var i = 0; i < matrix.Length; i++)
            {
                for(var j = 0; j < matrix[i].Length; j++)
                {
                    if(matrix[i][j] == 0)
                    {
                        s.Push(i);
                        s.Push(j);
                    }
                }
            }
            
            while(s.Count != 0)
            {
                var col = s.Pop();
                var row = s.Pop();
                matrix = ZeroCol(matrix, row);
                matrix = ZeroRow(matrix, col);
            }
        }
    
        public int[][] ZeroCol(int[][] m, int row)
        {
            int col = 0;
            while(col < m[row].Length)
            {
                m[row][col] = 0;
                col++;
            }
            return m;
        }
        
        public int[][] ZeroRow(int[][] m, int col)
        {
            int row = 0;
            while(row < m.Length)
            {
                m[row][col] = 0;
                row++;
            }
            return m;
        }

        public void SerZeroes2(int[][] matrix)
        {
            // if(matrix == null || matrix.Length == 0)
            //     return;
            bool first = false;
            int row = matrix.Length;
            int col = matrix[0].Length;
            
            for(var i = 0; i < row; i++)
            {
                if(matrix[i][0] == 0)
                    first = true;
                for(var j = 1; j < col; j++)
                {
                    if(matrix[i][j] == 0)
                    {
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }
                }
            }

            for (int i = 1; i < row; i++)
                for (int j = 1; j < col; j++)
                {
                    if(matrix[i][0] == 0 || matrix[0][j] == 0)
                        matrix[i][j] = 0;
                }
            
            if (matrix[0][0] == 0)
            {
                for (int i = 0; i < col; i++)
                {
                    matrix[0][i] = 0;
                }
            }

            if(first)
            {
                for(int i = 0; i < row; i++)
                {
                    matrix[i][0] = 0;
                }
            }
        }
    }
}