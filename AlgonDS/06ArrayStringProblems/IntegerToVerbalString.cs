using System.Collections.Generic;

namespace AlgonDS
{
    public class IntegerToVerbalString
    {
        public string ToWord(int number)
        {
            var units = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"
                , "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

            var tens = new string[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            var hundredDictionary = new Dictionary<int, string>()
            {
                {100,"hundred" },
                {1000,"Thousand" }
            };

            string verbalString = "";

            foreach (var item in hundredDictionary)
            {
                if ((number / item.Key) > 0)
                {
                    verbalString += " " + units[number / item.Key] + " " + item.Value;
                    number = number % item.Key;
                }

            }

            if (number < 20)
            {
                verbalString += " " + units[number];
            }
            else
            {
                verbalString += " " + tens[number / 10];
                number = number % 10;

                verbalString += " " + units[number];
            }

            return verbalString.Trim();
        }

        //brute force
        public string ToWord01(int number)
        {
            var units = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"
                , "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

            var tens = new string[] {"zero","ten","twenty","thirty","forty","fifty","sixty","seventy","eighty","ninety"};

            string verbalString = "";

            if ((number/1000)>0)
            {
                verbalString += " " + units[number / 1000] + " " + "thousand";
                number = number % 1000;
            }

            if ((number / 100) > 0)
            {
                verbalString += " " + units[number / 100] + " " + "hundred";
                number = number % 100;
            }

            if (number < 20)
            {
                verbalString += " " + units[number];                
            }
            else
            {
                verbalString += " " + tens[number / 10];
                number = number % 10;

                verbalString += " " + units[number];
            }

            return verbalString.Trim();
        }
    }
}
