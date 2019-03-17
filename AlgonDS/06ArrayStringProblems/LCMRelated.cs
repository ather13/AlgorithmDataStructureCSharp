
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// A common multiple is a number that is a multiple of two or more numbers. 
/// The common multiples of 3 and 4 are 0, 12, 24, .... 
/// The least common multiple (LCM) of two numbers is the smallest number (not zero) 
/// that is a multiple of both.
/// If we calculate LCM of two numbers then LCM of (a,b) is smallest positive number 
/// which divisible by both a & b. i.e. common multiple to both a & b
/// Example:
/// LCM of  5 , 2 = 10,  Because 10 is least common positive integer number 
/// which is devided by both 5 and 2 
/// LCM of 8, 9, 21=504, Because 504  is least common positive integer number 
/// which is devided by 8, 9, 21 or we can say 504 is smallest common multiple of 8,9,21 
/// </summary>
namespace AlgonDS
{
    public class LCMRelated
    {
        /// <summary>
        /// For two numbers
        /// LCM = (num1*num2)/gcd(a,b)
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public int LCMForTwoNumbers(int num1, int num2)
        {
            var gcd = new GCDRelated().GCDTwoNumbes(num1, num2);

            var lcd = (num1 * num2) / gcd;

            return lcd;
        }

        public int LCMForNNumberUsingTable(int[] nums)
        {
            var dividerList = new List<int>(); //store divider    
            var dic = nums.ToList(); //store nums and remainder
            var divider = 2;

            //till all the members in the list got divided and be zero
            while (dic.Count() > 0)
            {                
                var trueDivider = false; //flag to identify increment
                for (var i=dic.Count-1;i>=0; i--)
                {
                    if (dic[i] % divider == 0)
                    {
                        trueDivider = true;
                        var remainder = dic[i] / divider;
                        if (remainder == 1)
                        {
                            dic.Remove(dic[i]);
                        }
                        else
                        {
                            dic[i] = remainder;
                        }
                    }
                    else
                    {
                        if (dic[i] == 1)
                        {
                            dic.Remove(dic[i]);
                        }
                    }
                }
                if (trueDivider)
                {
                    dividerList.Add(divider);
                }
                else
                {
                    divider++;
                }
            }

            var result = 1;
            foreach (var item in dividerList)
            {
                result *= item;
            }

            return result;
        }
    }
}