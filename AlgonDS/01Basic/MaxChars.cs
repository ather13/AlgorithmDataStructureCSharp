
using System.Collections.Generic;

/// <summary>
/// Problem Statement :  maximum number of chars/digit in a given string
/// Examples : 
/// Hello => l
/// Hello 11213 => 1
/// </summary>

namespace AlgonDS
{
    public class MaxChars
    {
        public string FindMaxChars(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return word;
            }

            var store = new Dictionary<char, int>();
            var maxCount = 0;
            var maxChar = char.MinValue;

            foreach (var c in word)
            {
                if (store.ContainsKey(c))
                {
                    int count = store[c];
                    store[c] = ++count;
                }
                else
                {
                    store.Add(c, 1);
                }
            }

            foreach (var kv in store)
            {
                if (maxCount <kv.Value)
                {
                    maxCount = kv.Value;
                    maxChar = kv.Key;
                }
            }

            return maxChar.ToString();
        }

        //option 1 - with key value pair
        //public string FindMaxChars(string word)
        //{
        //    if (string.IsNullOrEmpty(word))
        //    {
        //        return word;
        //    }

        //    var store = new Dictionary<char, int>();
        //    var finalKeyValue = new KeyValuePair<char, int>();

        //    foreach (var c in word)
        //    {
        //        if (store.ContainsKey(c))
        //        {
        //            int count = store[c];
        //            store[c] = ++count;
        //        }
        //        else
        //        {
        //            store.Add(c, 1);
        //        }
        //    }
            
        //    foreach (var kv in store)
        //    {
        //        if (finalKeyValue.Equals(default(KeyValuePair<char, int>)))
        //        {
        //            finalKeyValue = kv;
        //        }
        //        else if (finalKeyValue.Value < kv.Value)
        //        {
        //            finalKeyValue = kv;
        //        }
        //    }

        //    return finalKeyValue.Key.ToString();
        //}
    }
}
