using System;

namespace Interview.Arrays._29
{
    public static class SortColors
    {

        public static void SortTheColors(int[] colors)
        {
            Console.Write("Input Array:: ");
            foreach (var item in colors)
            {
                System.Console.Write($"{item} ");
            }

            int start = 0;
            int end = colors.Length - 1;
            int index = 0;

            while(start < end && index <= end)
            {
                if(colors[index] == 0)
                {
                    swap(colors, index, start);
                    start++;
                    index++;
                }
                else if(colors[index] == 2)
                {
                    swap(colors, index, end);
                    end--;
                }
                else
                {
                    index++;
                }
            }

            Console.WriteLine();
            Console.Write("Output Array:: ");
            foreach (var item in colors)
            {
                System.Console.Write($"{item} ");
            }
        }

        private static void swap(int[] colors, int first, int second)
        {
            int temp = colors[first];
            colors[first] = colors[second];
            colors[second] = temp;
        }
    }
}
