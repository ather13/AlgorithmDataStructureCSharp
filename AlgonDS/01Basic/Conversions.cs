using System;
using System.Collections.Generic;
using System.Text;

namespace AlgonDS
{
    public class Conversions
    {
        public string DecimalToBinary(int n)
        {
            if (n < 2) return n.ToString();

            var result = string.Empty;

            while (n > 0)
            {
                var bin = n % 2;
                n = n / 2;

                result += bin;
            }
            return result;
        }

        public string BCL_DecimalToBinary(int n)
        {
            return Convert.ToString(n, 2);
        }
    }
}
