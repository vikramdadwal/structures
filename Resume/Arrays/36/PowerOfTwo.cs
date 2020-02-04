using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Arrays._36
{
    public static class PowerOfTwo
    {
        public static bool IsPOwerOfTwo(int n)
        {
            long i = 1;

            while(i < n)
            {
                i = i * 2;
            }

            if(i == n)
            {
                return true;
            }

            return false;
        }
    }
}
