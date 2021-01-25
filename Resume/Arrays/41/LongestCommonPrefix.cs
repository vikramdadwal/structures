using System.Linq;

namespace Interview.Arrays._41
{
    /// <summary>
    /// https://leetcode.com/problems/longest-common-prefix/
    /// </summary>
    public class LongestCommonPrefix
    {
        public static string FindCommonPrefix(string[] words)
        {
            string longestCommonPrefix = string.Empty;

            if (words == null || words.Count() == 0)
            {
                return longestCommonPrefix;
            }

            int index = 0;
            var firstStringCharacters = words[0].ToCharArray();

            foreach (var cha in firstStringCharacters)
            {
                for (int i = 1; i < words.Length; i++)
                {
                    var stringCHars = words[i].ToCharArray();

                    if (index >= words[i].Length || stringCHars[index] != cha)
                    {
                        return longestCommonPrefix;
                    }
                }

                longestCommonPrefix = longestCommonPrefix + cha;
                index++;
            }

            return longestCommonPrefix;
        }
    }
}
