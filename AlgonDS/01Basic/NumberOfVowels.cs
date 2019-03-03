/// <summary>
/// Problem Statement :  find the number of vowels[a,e,i,o,u] in given stirng
/// Examples : 
/// hello   => 2
/// India   => 3
/// America => 4
/// </summary>

using System.Linq;
using System.Text.RegularExpressions;

namespace AlgonDS
{
    public class NumberOfVowels
    {

        //option 3 - regex
        public int GetNumberOfVowels(string word)
        {
            var matches = Regex.Matches(word,"[aeiou]");

            var counter = matches.Count();

            return counter;
        }

        ////option 2 - linq
        //public int GetNumberOfVowels(string word)
        //{
        //    char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        //    var counter = word.ToLower().Count(c => vowels.Contains(c));

        //    return counter;
        //}

        //option 1 - brute force
        //public int GetNumberOfVowels(string word)
        //{
        //    char[] vowels = {'a','e','i','o','u'};
        //    int counter = 0;
        //    foreach (var c in word)
        //    {
        //        foreach (var v in vowels)
        //        {
        //            if (v == c)
        //            {
        //                counter++;
        //                break;
        //            }
        //        }
        //    }

        //    return counter;
        //}
    }
}
