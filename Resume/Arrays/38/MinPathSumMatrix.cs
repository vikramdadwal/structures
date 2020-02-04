using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Arrays._38
{
    public class MinPathSumMatrix
    {
        public static int GetMinPathSum(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            var tempMatrix = new int[rows, columns];

            int sum = 0;

            for(int column = 0; column < columns; column++)
            {
                tempMatrix[0, column] = sum + matrix[0, column];
                sum = tempMatrix[0, column];
            }

            sum = 0;

            for (int row = 0; row < rows; row++)
            {
                tempMatrix[row, 0] = sum + matrix[row, 0];
                sum = tempMatrix[row, 0];
            }

            for(int row = 1; row < rows; row++)
            {
                for (int column = 1; column < columns; column++)
                {
                    tempMatrix[row, column] = matrix[row, column] + Math.Min(tempMatrix[row - 1, column], tempMatrix[row, column - 1]);
                    sum = tempMatrix[row, column];
                }

            }

            return tempMatrix[rows - 1, columns - 1];
        }
    }
}
