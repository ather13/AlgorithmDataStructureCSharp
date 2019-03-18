
using System;
using System.Linq;

/// <summary>
/// Given a positive integer n, count the total number of set bits 
/// in binary representation of all numbers from 1 to n.
/// 
/// Example :
/// 3 => 4
/// 6 => 9
/// </summary>
namespace AlgonDS
{
    public class BitsCount
    {
        public int BitsCountInGivenNumber(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            var counter = 2;

            for (var i = 3; i <= n; i++)
            {
                var binary = Convert.ToString(i, 2);
                counter += binary.Count(x => char.GetNumericValue(x) == 1);
            }

            return counter;
        }
    }
}
