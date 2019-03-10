using System;
using System.Collections.Generic;
using System.Text;

namespace AlgonDS
{
    public class SquareRoot
    {
        public int Getsquareroot(int n)
        {
            if (n == 0 || n == 1)
                return n;

            var sqrt = 1;
            for (int i = 1; i <= n; i++)
            {
                sqrt = i;
                if (i * i == n)
                {
                    break;
                }
            }

            return sqrt;
        }
    }
}
