using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Interview.Arrays._37
{
    public static class PalindromeORNot
    {
        public static bool IsPalindrome(string input)
        {
            char[] chars = input.ToCharArray();
            int i = 0;
            int j = chars.Length - 1;

            while(i < j)
            {
                while(i < j && !Utility.IsVaildAlphaNumericCHar(chars[i].ToString()))
                {
                    i++;
                }

                while(i < j && !Utility.IsVaildAlphaNumericCHar(chars[j].ToString()))
                {
                    j--;
                }

                if(i< j && chars[i].ToString().ToLower() != chars[j].ToString().ToLower())
                {
                    return false;
                }

                i++;
                j--;
            }

            return true;

        }

        public static bool IsPalindrome202(string input)
        {
            char[] allchars = input.ToLower().ToCharArray();

            int i = 0;
            int j = allchars.Length - 1;

            while(i < j)
            {

                while(i < j && !char.IsLetterOrDigit(allchars[i]))
                {
                    i++;
                }

                while(i < j && !char.IsLetterOrDigit(allchars[j]))
                {
                    j--;
                }

                if(allchars[i] != allchars[j])
                {
                    return false;
                }

                i++;
                j--;
            }

            return true;
        }

        
    }
}
