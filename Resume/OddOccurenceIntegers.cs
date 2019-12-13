using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Interview
{
    public static class OddOccurenceIntegers
    {
        public static void PrintOddOccurenceIntegers(int[] intArray)
        {
            Array.Sort(intArray);
            int previous = intArray[0];
            int counter = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (previous != intArray[i])
                {
                    if (counter % 2 == 0)
                    {
                        Console.WriteLine(previous);
                    }
                    counter = 0;
                }

                counter++;
                previous = intArray[i];
                if (i == intArray.Length - 1)
                {
                    if (counter % 2 == 0)
                    {
                        Console.WriteLine(previous);
                    }
                }
            }
        }

        public static int FindUniqueIntegerFromPairs(int[] pairs)
        {
            int uniqueNumber = pairs[0];
            for (int i = 1; i < pairs.Length; i++)
            {
                uniqueNumber = uniqueNumber ^ pairs[i];
            }

            return uniqueNumber;

        }

        public static void PrintPairToEqualsSum(int[] array, int sum)
        {
            var hash = new Dictionary<int, int>();

            //List<string> dfdf = new List<string>();
            //dfdf.First
            
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (!hash.ContainsKey(array[i]))
                {
                    hash.Add(array[i], i);
                }

            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (hash.ContainsKey(sum - array[i]))
                {
                    var value = hash[sum - array[i]];

                    if (value != i)
                    {
                        Console.WriteLine("pair " + i + ", " + hash[sum - array[i]] + " has sum =" + sum);
                    }

                }

            }
        }

        public static void IsNumberIsPalindrome(int number)
        {
            int num = number;
            int temp = 0;
            int rev = 0;

            while (num > 0)
            {
                temp = num % 10;
                rev = rev * 10 + temp;
                num = num / 10;
            }

            if (number == rev)
            {
                Console.WriteLine(number + " is palindrome");
            }
            else
            {
                Console.WriteLine(number + " is  not a palindrome");
            }

        }

        //$$$ You are given an array with integers (both positive and negative) in any random order. 
        ///$$$$ Find the sub-array with the largest sum. 
        //Find max sub array having max sum --- Brute FOrce = O(n^3)
        public static int FindMaximumSubArraySum(int[] array)
        {
            int answer = int.MinValue;

            for (int subarraysize = 1; subarraysize <= array.Length; subarraysize++)
            {
                for (int startindex = 0; startindex < array.Length; startindex++)
                {
                    if (startindex + subarraysize > array.Length)
                    {
                        break;
                    }

                    int sum = 0;
                    for (int index = startindex; index < startindex + subarraysize; index++)
                    {
                        sum = sum + array[index];
                    }

                    answer = sum > answer ? sum : answer;
                }
            }
            return answer;
        }

        //Find max sub array having max sum --- Improved = O(n^2)
        public static int FindMaximumSubArraySum22(int[] array)
        {
            int answer = int.MinValue;
            for (int startindex = 0; startindex < array.Length; startindex++)
            {
                int sum = 0;
                for (int subarraysize = 1; subarraysize <= array.Length; subarraysize++)
                {
                    if (startindex + subarraysize > array.Length)
                    {
                        break;
                    }

                    sum += array[startindex + subarraysize - 1];


                    answer = sum > answer ? sum : answer;
                }
            }

            return answer;
        }

        //KAdanes algorithm. O(n)  --- only works if it contains one positive elemnent
        public static int FindMaximumSubArraySum33(int[] array)
        {
            int ans = 0, sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (sum + array[i] > 0)
                {
                    sum += array[i];
                }
                else
                {
                    sum = 0;
                }

                ans = ans > sum ? ans : sum;
            }

            return ans;

        }

        #region > Merge sorted array <

        //How to merge two sorted arrays into a single sorted array? -- O(n)
        public static int[] MergeSortedArray(int[] a, int[] b)
        {
            int[] answer = new int[a.Length + b.Length];
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                {
                    answer[k] = a[i];
                    i++;
                }
                else
                {
                    answer[k] = b[j];
                    j++;
                }

                k++;

            }

            while (i < a.Length)
            {
                answer[k] = a[i];
                i++; k++;
            }

            while (j < b.Length)
            {
                answer[k] = a[j];
                j++; k++;
            }

            return answer;
        }

        /// <summary>
        /// start from the end of the array
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="alength"></param>
        /// <param name="blength"></param>
        public static void MergeSortedArrayNoSpace(int[] a, int[] b, int alength, int blength) // alength is numbe of element in array
        {
            int alastindex = alength - 1;
            int blastindex = blength - 1;

            int mergeLastindex = alength + blength - 1;

            while(blastindex >= 0)
            {
                if(alastindex >=0 && a[alastindex] > b[blastindex])
                {
                    a[mergeLastindex] = a[alastindex];
                    alastindex--;
                }
                else
                {
                    a[mergeLastindex] = b[blastindex];
                    blastindex--;
                }

                mergeLastindex--;
            }
        }
        #endregion


        /// <summary>
        /// waterbottle  = erbottlewat
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool IsRotation(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            string s1s1 = s1 + s1;

            //return IsSubstring(s1s1, s2);

            return false;
        }

        /// <summary>
        /// string is permutation of a palindrome
        /// </summary>
        /// <param name="s1"></param>
        /// <returns></returns>
        public static bool CheckIfPermutationOFPalindrome(string s1)
        {
            Dictionary<char, int> hash = new Dictionary<char, int>();

            char[] array = s1.ToCharArray();

            foreach (char ch in array)
            {
                if (!hash.ContainsKey(ch))
                {
                    hash.Add(ch, 1);
                }
                else
                {
                    hash[ch] = hash[ch] + 1;
                }
            }

            int count = 0;
            foreach (var pair in hash)
            {
                if (pair.Value % 2 != 0)
                {
                    count++;
                }
            }

            return count <= 1;

        }
    }
}
