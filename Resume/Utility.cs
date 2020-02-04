using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Interview
{
    public class Utility
    {
        public static void swap(int[] colors, int first, int second)
        {
            int temp = colors[first];
            colors[first] = colors[second];
            colors[second] = temp;
        }

        public static void PrintArray<T>(T[] array, string message)
        {
            Console.WriteLine();
            Console.Write(message);
            foreach (var item in array)
            {
                System.Console.Write($"{item} ");
            }
        }

        public static bool IsVaildAlphaNumericCHar(string strToCheck)
        {
            return strToCheck.All(char.IsLetterOrDigit);
        }
    }
}
