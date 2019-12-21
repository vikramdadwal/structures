using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Arrays._26
{
    public static class StringCompression
    {
        public static string CompressString(string input)
        {
            int sum = 1;
            string output = "";

            for(int i = 0; i < input.Length - 1; i++)
            {
                if(input[i] == input[i+1])
                {
                    sum++;
                }
                else
                {
                    output = output + input[i] + sum.ToString();
                    sum = 1;
                }
            }

            output = output + input[input.Length - 1] + sum.ToString();

            return output.Length > input.Length ? input : output;
        }
    }
}
