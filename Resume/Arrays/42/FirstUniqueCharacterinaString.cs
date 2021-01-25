using System.Collections.Generic;

namespace Interview.Arrays._42
{
    public class FirstUniqueCharacterinaString
    {
        public static int FirstIndex(string input)
        {
            char[] allchars = input.ToCharArray();

            Dictionary<char, int> mapper = new Dictionary<char, int>();

            for (int i = 0; i < allchars.Length; i++)
            {   
                if(mapper.ContainsKey(allchars[i]))
                {
                    mapper[allchars[i]] = -1;
                }
                else
                {
                    mapper[allchars[i]] = i;
                }
            }

            int min = int.MaxValue;
            foreach (var key in mapper.Keys)
            {
                if(mapper[key] > -1 && mapper[key] < min)
                {
                    min = mapper[key];
                }
            }

            return min == int.MaxValue ? -1 : min;
        }
    }
}
