using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public static class Sorting
    {
        /// <summary>
        /// Keep shifting the min values to the left
        /// Input = 2, 5, 3, 1, 6
        /// 1 go = 1, 5, 3, 2, 6
        /// 2 go = 1, 2, 3, 5, 6
        /// </summary>
        /// <param name="array"></param>
        public static void SelectionSort(int[] array)
        {
            // time complexity = O(n^2)
            var length = array.Length;
            for(int i = 0; i < length - 1; i++) // length -1 because last element will already be in right position once sorting is complete
            {
                int minindex = i;
                for(int j = minindex+1; j < length; j++)
                {
                    if(array[j] < array[minindex])
                    {
                        minindex = j;
                    }
                }

                var temp = array[i];
                array[i] = array[minindex];
                array[minindex] = temp;
            }
        }
    }
}
