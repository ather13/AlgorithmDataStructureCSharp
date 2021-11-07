using System;
using System.Collections.Generic;

namespace AlgonDS._14DpMemoization
{
    /// <summary>
    /// Decision Problem
    /// </summary>
    public class CanConstructProblem
    {
        /// <summary>
        /// Brute force - Recursive
        /// Space : O(m^2)
        /// Time  : O(n^m * m)
        /// m = target word, n = length of word bank
        /// </summary>
        public bool CanConstructiveRecursive(string target, string[] wordBank)
        {
            if (string.IsNullOrEmpty(target)) return true;

            foreach (var word in wordBank)
            {
                var index = target.IndexOf(word, StringComparison.OrdinalIgnoreCase);
                
                if (index == 0)
                {
                    var newTarget =  target[word.Length..]; // similar to "target.Substring(word.Length);"

                    if (CanConstructiveRecursive(newTarget, wordBank))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Brute force - Recursive Memo
        /// Space : O(m^2)
        /// Time  : O(n * m^2)
        /// m = target word, n = length of word bank
        /// </summary>
        public bool CanConstructiveRecursiveMemo(string target, string[] wordBank,Dictionary<string,bool> memo = null)
        {
            memo ??= new Dictionary<string, bool>();
            if (memo.ContainsKey(target)) return memo[target];

            if (string.IsNullOrEmpty(target)) return true;

            foreach (var word in wordBank)
            {
                var index = target.IndexOf(word, StringComparison.OrdinalIgnoreCase);

                if (index == 0)
                {
                    var newTarget = target[word.Length..]; // similar to "target.Substring(word.Length);"

                    if (CanConstructiveRecursiveMemo(newTarget, wordBank,memo))
                    {
                        memo.Add(newTarget,true);
                        return true;
                    }
                }
            }

            memo.Add(target, false);
            return false;
        }
    }
}
