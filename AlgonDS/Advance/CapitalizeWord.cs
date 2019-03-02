
using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Globalization;

/// <summary>
/// Problem Statement :  Capitalizing first letter of each word in a sentence
/// Examples : 
/// "hEllo world"   => "Hello World!"
/// "I love dogs" => "I Love Dogs"
/// "This is great world" => "This Is Great World!"
/// </summary>
namespace AlgonDS
{
    public class CapitalizeWord
    {
        public string CapitalizeMe(string sentence)
        {
            return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(sentence.ToLower());
        }

            //option 2 - remove inner loop
            //public string CapitalizeMe(string sentence)
            //{
            //    if (string.IsNullOrEmpty(sentence)) return sentence;

            //    var lowerSentence = sentence.ToLower();

            //    var arraySentence = lowerSentence.Split(" ");

            //    for (int i = 0; i < arraySentence.Length; i++)
            //    {
            //        //handle space 
            //        if (arraySentence[i].Length > 0)
            //        {
            //            var tempSentence = char.ToUpper(arraySentence[i].First()).ToString();
            //            if (arraySentence[i].Length > 1) {
            //                tempSentence = tempSentence + arraySentence[i].Substring(1);
            //            }
            //            arraySentence[i] = tempSentence;
            //        }
            //    }

            //    var finalString = string.Join(" ", arraySentence);

            //    return finalString;
            //}

            //option 1 - brute force
            //public string CapitalizeMe(string sentence)
            //{
            //    if (string.IsNullOrEmpty(sentence)) return sentence;

            //    var lowerSentence = sentence.ToLower();

            //    var arraySentence = lowerSentence.Split(" ");

            //    for (int i = 0; i < arraySentence.Length; i++)
            //    {
            //        var tempSentence = string.Empty;
            //        for (int j = 0; j < arraySentence[i].Length; j++)
            //        {
            //            if (j == 0)
            //                tempSentence = char.ToUpper(arraySentence[i][j]).ToString();
            //            else
            //                tempSentence += arraySentence[i][j];
            //        }
            //        arraySentence[i] = tempSentence;
            //    }

            //    var finalString = string.Join(" ", arraySentence);

            //    return finalString;
            //}
        }
}
