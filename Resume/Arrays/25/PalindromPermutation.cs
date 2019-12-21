namespace Interview.Arrays._25
{
    public static class PalindromPermutation
    {
        public static bool HasPalindrom(string input)
        {
            int[] count_of_chars = new int[128];

            for(int i= 0; i<input.Length; i++)
            {
                count_of_chars[input[i]]++;
            }

            int count = 0;

            for(int i=0; i< 128; i++)
            {
                count += count_of_chars[i] % 2;
            }

            if(count > 1)
            {
                return false;
            }

            return true;
        }
    }
}
