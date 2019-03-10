using System;

namespace AlgonDS
{
    public class AddTwoBinary
    {
        //assuming both number has same length
        public string Calculate(string num1, string num2)
        {
            var carry = 0;
            var result = string.Empty;
            for (var i = num1.Length - 1; i >= 0; i--)
            {
                var num = Char.GetNumericValue(num1[i]) + Char.GetNumericValue(num2[i]) + carry;
                if (num > 1)
                {
                    num = 0;
                    carry = 1;
                }
                result = num + result;
            }

            return result;
        }
    }
}
