/// <summary>
/// GCD (Greatest common divisor) or HCF (Highest common factor) of two or more numbers 
/// (integers) is the largest positive integer that divides those numbers 
/// without a remainder.
/// Example: GCD (8,12)=4 Because 4 is highest number which devides both 8 and 12 completely i.e. without remainder.
/// GCD(50, 25, 100)= 25 Because 25 is highest number which devides all three numbers.
/// </summary>

namespace AlgonDS
{
    public class GCDRelated
    {
        public int GCDMoreThan2Numbers(int[] numbers)
        {
            if (numbers.Length == 1)
                return numbers[0];

            var gcd = numbers[0];
            for(var i= 1;i<numbers.Length;i++)
            {
                var num2 = numbers[i];
                if (gcd < num2)
                {
                    var t = gcd;
                    gcd = num2;
                    num2 = t;
                }

                gcd = DoGCDOfTwoNumbers(gcd, num2);
            }

            return gcd;
        }

        public int GCDTwoNumbes(int num1,int num2)
        {
            if (num1 < num2)
            {
                var t = num1;
                num1 = num2;
                num2 = t;
            }

            return DoGCDOfTwoNumbers(num1, num2);
        }

        /// <summary>
        /// The Euclidean algorithm to solve the problem
        /// Do till the remainder become zero
        /// - Divide 210 by 45, and get the result 4 with remainder 30
        /// - Divide 45 by 30, and get the result 1 with remainder 15
        /// - Divide 30 by 15, and get the result 2 with remainder 0
        /// The greatest common divisor of 210 and 45 is 15.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        private int DoGCDOfTwoNumbers(int num1, int num2)
        {
            var remainder = num1 % num2;
            if (remainder == 0)
                return num2;

            return DoGCDOfTwoNumbers(num1, remainder);
        }
    }
}
