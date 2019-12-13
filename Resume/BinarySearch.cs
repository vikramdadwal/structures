using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class BinarySearch
    {
        public static void BInarySearch(int[] array, int value)
        {
            Array.Sort(array);
            int start = 0;
            int end = array.Length;
            int mid = 0;

            while(start <= end)
            {
                mid = (start + end) / 2;

                if(array[mid] == value)
                {
                    Console.Write("Found at index: " + mid);
                    break;
                }
                else if(array[mid] > value)
                {
                    end = mid - 1;
                } else if (array[mid] < value)
                {
                    start = mid + 1;
                }                
            }

            //Console.WriteLine("Noopppsssss");

        }

        public static bool BInarySearchRecursive(int[] array, int start, int end, int value)
        {
            if(start >=end)
            {
                return false;
            }
            bool result = false;

            int mid = (start + end) / 2;

            if (array[mid] == value)
            {
                Console.Write("Found at index: " + mid);
                result = true;
            }
            else if (array[mid] > value)
            {
               result =  BInarySearchRecursive(array, start, mid - 1, value);
            }
            else if (array[mid] < value)
            {
                result = BInarySearchRecursive(array, mid + 1, end, value);
            }

            return result;
        }

        public static void DoBinarySearch(int[] array, int value)
        {
            BInarySearchRecursive(array, 0, array.Length, value);
        }

        public static int FindWithBinarySearch(int[] array, int value, bool isFirst)
        {
            int result = -1;

            int mid = 0;
            int start = 0;
            int end = array.Length;

            while(start <= end)
            {
                mid = (start + end) / 2;

                if(array[mid] == value)
                {
                    result = mid;
                    if (isFirst)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }

                }
                else if(array[mid] > value)
                {
                    end = mid - 1;
                }
                else if(array[mid] < value)
                {
                    start = mid + 1;
                }
            }

            return result;
        }

        // Find repeated occurance best case
        /// <summary>
        /// Count occurrences of a number in a sorted array with duplicates using Binary Search
        /// </summary>
        public static void PrintOccurance()
        {
            // Time complexity O(log n)
            int[] array = new[] { 1, 2, 3, 4, 4, 4, 5, 5, 5, 5, 7, 8 };

            int firstIndex = FindWithBinarySearch(array, 5, true);

            int lastindex = FindWithBinarySearch(array, 5, false);

            Console.Write("Occurance of 4:    => " + ((lastindex - firstIndex) + 1));
        }

        /// <summary>
        /// Search element in a circular sorted array
        /// </summary>
        /// <returns></returns>
        public static int SearchElementCirculerSortArray(int[] array, int value)
        {
            //   12, 14, 18, 21, 3, 6, 8, 9
            int mid = 0;
            int start = 0;
            int end = array.Length;

            while(start <= end)
            {
                mid = (start + end) / 2;

                if (array[mid] == value) return mid;
                else if(array[mid] <= array[end]) // Case 2 : Right half is sorted
                {
                    if(value > array[mid] && value <= array[end]) // Case 2A: go searching in right side
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
                else if(array[mid] >= array[start])  // Case 3:Left half is sorted
                {
                    if(value >= array[start] && value < array[mid]) // Case 3a: go search in left side
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }

                }

            }

            return -1;
        }
    }
}
