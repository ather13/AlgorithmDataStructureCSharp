/// <summary>
/// Problem Statement :  reverse number 
/// Examples : 
/// 123 => 321
/// 100 => 1
/// -12 => -21
/// </summary>

namespace AlgonDS
{
    public class ReverseNumber
    {
        //option 3
        public int ReverseMe(int numeric)
        {
            int reverseNumber = 0;

            while (numeric != 0)
            {
                var extractedNumber = numeric % 10;
                reverseNumber = (reverseNumber * 10) + extractedNumber;
                numeric = numeric / 10;
            }

            return reverseNumber;
        }

        ////option2 - reverse numeric as string
        //public int ReverseMe(int numeric)
        //{
        //    var numericWord = (numeric * Math.Sign(numeric)).ToString();

        //    var reverseString = (new ReverseString()).ReverseMe(numericWord);

        //    return int.Parse(reverseString) * Math.Sign(numeric);
        //}

        ////option1 - reverse numeric as string
        //public int ReverseMe(int numeric)
        //{
        //    var numericWord = numeric.ToString();

        //    if (numericWord.Length == 1) return numeric;

        //    char sign = Char.MinValue;

        //    var start = 0;

        //    //remove signs (+ or -) before reversing and store it to add at the end
        //    if ((numericWord[0] == '+') || (numericWord[0] == '-'))
        //    {
        //        sign = numericWord[0];
        //        start = 1;
        //    }

        //    var reverseString = string.Empty;
        //    for (int i = numericWord.Length - 1; i >= start; i--)
        //    {
        //        reverseString += numericWord[i];
        //    }

        //    //add signs (+ or -) to the numeric string which is reversed
        //    if (sign != Char.MinValue)
        //    {
        //        reverseString = sign + reverseString;
        //    }

        //    return int.Parse(reverseString);
        //}
    }
}
