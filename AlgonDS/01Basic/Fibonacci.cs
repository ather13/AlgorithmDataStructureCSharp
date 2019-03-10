using System;
using System.Collections.Generic;
using System.Text;

namespace AlgonDS
{
    public class Fibonacci
    {
        public int GetFibonacci(int n)
        {
            if (n == 2 || n == 1)
            {
                return 1;
            }

            var val = GetFibonacci(n - 1) + GetFibonacci(n - 2);

            return val;
        }

        //this is used to concatenate
        public string GetFibonacci2List(int n)
        {
            var str = string.Empty;
            foreach (var item in GetFibonacci2(n))
            {
                str = str + "," + item;
            }

            return str;
        }

        public IEnumerable<int> GetFibonacci2(int n)
        {
            var fPrevVal = 0;
            var sPrevVal = 1;

            yield return fPrevVal;
            yield return sPrevVal;

            for (int i = 2; i <= n; i++)
            {

                var val = fPrevVal + sPrevVal;
                fPrevVal = sPrevVal;
                sPrevVal = val;

                yield return val;
            }
        }
    }
}
