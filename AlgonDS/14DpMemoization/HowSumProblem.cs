using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgonDS._14DpMemoization
{
    /// <summary>
    /// Combinatorics problems
    /// </summary>
    public class HowSumProblem
    {
        /// <summary>
        /// Recursive with Memoization
        /// Space : 
        /// Time  : 
        /// </summary>
        public int[] GetHowSumMemo(int Sum, int[] numbers,Dictionary<int,int[]> memo=null)
        {
            memo ??= new Dictionary<int, int[]>();
            if (memo.ContainsKey(Sum)) return memo[Sum];
            if (Sum == 0) return Array.Empty<int>();
            if (Sum < 0) return null;

            foreach (var num in numbers)
            {
                var newSum = Sum - num;
                var result = GetHowSumMemo(newSum, numbers,memo);
                if (result != null)
                {
                    memo.Add(Sum, result.Append(num).ToArray());
                    return memo[Sum];
                }
            }

            memo.Add(Sum, null);
            return null;
        }

        /// <summary>
        /// Brute Force - Recursive
        /// Space : 
        /// Time  : 
        /// </summary>
        public int[] GetHowSum(int sum, int[] numbers)
        {
            if (sum == 0) return Array.Empty<int>();
            if (sum < 0) return null;

            foreach (var num in numbers)
            {
                var newSum = sum - num;
                var result = GetHowSum(newSum, numbers);
                if (result != null)
                {
                    return result.Append(num).ToArray();
                }
            }
            
            return null;
        }
    }
}
