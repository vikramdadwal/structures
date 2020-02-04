using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Arrays._1
{
    public static class NumberOfIslands
    {
        public static int FindNumberOfIslands(int[,] array)
        {
            int numberofislands = 0;
            // Note 0 represent rows and 1 represent columns in GetLength
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    if (array[row, column] == 1)
                    {
                        numberofislands++;
                        ChangeLandToWater(array, row, column);
                    }
                }
            }

            return numberofislands;
        }

        private static void ChangeLandToWater(int[,] array, int row, int column)
        {
            if (row >= array.GetLength(0) || row < 0 || column < 0 || column >= array.GetLength(1) || array[row, column] == 0)
            {
                return;
            }

            array[row, column] = 0;
            ChangeLandToWater(array, row - 1, column); // up
            ChangeLandToWater(array, row + 1, column); // down
            ChangeLandToWater(array, row, column - 1); // left
            ChangeLandToWater(array, row, column + 1); // right
        }
    }
}
