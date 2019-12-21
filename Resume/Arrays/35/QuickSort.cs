namespace Interview.Arrays._35
{
    public static class QuickSort
    {
        public static void PerformQuickSort(int[] input)
        {
            Utility.PrintArray<int>(input, "Input Array:::  ");
            QuickSortAlgo(input, 0, input.Length - 1);
            Utility.PrintArray<int>(input, "Output Array:::  ");
        }

        private static void QuickSortAlgo(int[] input, int start, int end)
        {
            if (start < end)
            {
                int partitionIndex = Partition(input, start, end);
                QuickSortAlgo(input, start, partitionIndex - 1);
                QuickSortAlgo(input, partitionIndex + 1, end);
            }
        }

        private static int Partition(int[] input, int start, int end)
        {
            int pivot = input[end];
            int partitionIndex = start;

            for(int i=start; i< end; i++)
            {
                if(input[i] < pivot)
                {
                    Utility.swap(input, i, partitionIndex);
                    partitionIndex++;
                }
            }

            Utility.swap(input, end, partitionIndex);
            return partitionIndex;
        }
    }
}
