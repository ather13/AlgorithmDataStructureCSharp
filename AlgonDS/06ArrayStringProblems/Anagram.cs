/// <summary>
/// Problem Statement :  Two words are said to be Anagrams of each other 
/// if they share the same set of letters to form the respective words.
/// Remember, it’s just rearranging the existing letter set. For example, Silent and Listen.
/// Examples : 
/// tear = rate
/// Elvis = Lives
/// Jim Morrison = Mr. Mojo Risin
/// are = area => Not an anagram
/// India = Diana => Not an anagram 
/// </summary>

using System;
using System.Text.RegularExpressions;

namespace AlgonDS
{
    public class Anagram
    {
        //considering anagram shouldnt have any numeric letter
        public bool IsWordsAnagram(string firstWord, string secondWord)
        {
            if (string.IsNullOrEmpty(firstWord) || string.IsNullOrEmpty(secondWord)) return false;

            var fword = CleanString(firstWord);
            var sword = CleanString(secondWord);

            if (fword == sword)
                return true;
            else
                return false;
        }

        public string CleanString(string word)
        {
        //to understand every step clearly code is written in spearte line
        //this code can be combine and make it shorter
           var regexWord = Regex.Replace(word, "[^a-zA-Z]+", "");

            var lowerWord = regexWord.ToLower();

            var charArray = lowerWord.ToCharArray();

            Array.Sort(charArray);

            return new string(charArray);
        }

            //option 1 - brute force
        //    public bool IsWordsAnagram(string firstWord,string secondWord)
        //{
        //    if (string.IsNullOrEmpty(firstWord) || string.IsNullOrEmpty(secondWord)) return false;

        //    //ignore case difference
        //    firstWord = firstWord.ToLower();
        //    secondWord = secondWord.ToLower();

        //    if (firstWord.Equals(secondWord)) return true;
            
        //    string fWord = string.Empty;
        //    string sWord = string.Empty;
                       
        //    //remove special characters
        //    foreach (var c in firstWord)
        //    {
        //        if (char.IsLetterOrDigit(c))
        //        {
        //            fWord += c;
        //        }
        //    }

        //    foreach (var c in secondWord)
        //    {
        //        if (char.IsLetterOrDigit(c))
        //        {
        //            sWord += c;
        //        }
        //    }

        //    if (fWord.Length != sWord.Length) return false;

        //    var fWordStore = new Dictionary<char, int>();
        //    var sWordStore = new Dictionary<char, int>();

        //    for (int i = 0; i < fWord.Length; i++)
        //    {
        //        if (fWordStore.ContainsKey(fWord[i]))
        //        {
        //            fWordStore[fWord[i]] = ++fWordStore[fWord[i]];
        //        }
        //        else
        //        {
        //            fWordStore.Add(fWord[i], 1);
        //        }

        //        if (sWordStore.ContainsKey(sWord[i]))
        //        {
        //            sWordStore[sWord[i]] = ++sWordStore[sWord[i]];
        //        }
        //        else
        //        {
        //            sWordStore.Add(sWord[i], 1);
        //        }
        //    }

        //    if (fWordStore.Keys.Count != sWordStore.Keys.Count) return false;

        //    foreach (var keyValue in fWordStore)
        //    {
        //        if (fWordStore[keyValue.Key] != sWordStore[keyValue.Key]) return false;                
        //    }

        //    return true;
        //}
    }
}
