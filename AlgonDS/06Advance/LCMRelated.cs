/// <summary>
/// A common multiple is a number that is a multiple of two or more numbers. 
/// The common multiples of 3 and 4 are 0, 12, 24, .... 
/// The least common multiple (LCM) of two numbers is the smallest number (not zero) 
/// that is a multiple of both.
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
        public int LCMForTwoNumbers(int num1,int num2)
        {
            var gcd = new GCDRelated().GCDTwoNumbes(num1, num2);

            var lcd = (num1 * num2) / gcd;

            return lcd;
        }
    }
}
