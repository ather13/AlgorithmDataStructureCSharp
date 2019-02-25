/// <summary>
/// Problem Statement :  Display words based on numbers
/// Division by 3 => Fizz
/// Division by 5 => Buzz
/// Division by 3 & 5] => FizzBuzz
/// 
/// Examples : 
/// 1
/// 2
/// Fizz
/// 4
/// Buzz
/// 6
/// .
/// 14
/// FizzBuzz
/// 16
/// </summary>

namespace AlgonDS
{
    public class FizzBuzz
    {
        //option 2 - only if condition
        public string[] GetFizzBuzz(int[] toBeFizzBuzz)
        {
            string[] FizzBuzz = new string[toBeFizzBuzz.Length];

            for (int i = 0; i < toBeFizzBuzz.Length; i++)
            {
                if ((toBeFizzBuzz[i] % 3) == 0)
                {
                    FizzBuzz[i] = "Fizz";
                }
                if ((toBeFizzBuzz[i] % 5) == 0)
                {
                    FizzBuzz[i] += "Buzz";
                }
                if (string.IsNullOrEmpty(FizzBuzz[i]))
                {
                    FizzBuzz[i] = toBeFizzBuzz[i].ToString(); ;
                }
            }
            return FizzBuzz;
        }


        //option 1 - if else condition
        //public string[] GetFizzBuzz(int[] toBeFizzBuzz)
        //{
        //    string[] FizzBuzz=new string[toBeFizzBuzz.Length];

        //    for (int i = 0; i < toBeFizzBuzz.Length; i++)
        //    {
        //        if ((toBeFizzBuzz[i] % 3) == 0 && (toBeFizzBuzz[i] % 5) == 0)
        //        {
        //            FizzBuzz[i] = "FizzBuzz";
        //        }
        //        else if ((toBeFizzBuzz[i] % 3) == 0)
        //        {
        //            FizzBuzz[i] = "Fizz";
        //        }
        //        else if ((toBeFizzBuzz[i] % 5) == 0)
        //        {
        //            FizzBuzz[i] = "Buzz";
        //        }
        //        else
        //        {
        //            FizzBuzz[i] = toBeFizzBuzz[i].ToString(); ;
        //        }
        //    }
        //    return FizzBuzz;
        //}
    }
}
