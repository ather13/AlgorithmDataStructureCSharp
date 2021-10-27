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
        /// Space : O(m)
        /// Time  : O(n^m * m)
        /// m = target sum, n = length of numbers array
        /// </summary>
        public int[] GetHowSumMemo(int sum, int[] numbers,Dictionary<int,int[]> memo=null)
        {
            memo ??= new Dictionary<int, int[]>();
            if (memo.ContainsKey(sum)) return memo[sum];
            if (sum == 0) return Array.Empty<int>();
            if (sum < 0) return null;

            foreach (var num in numbers)
            {
                var newSum = sum - num;
                var result = GetHowSumMemo(newSum, numbers,memo);
                if (result != null)
                {
                    memo.Add(sum, result.Append(num).ToArray());
                    return memo[sum];
                }
            }

            memo.Add(sum, null);
            return null;
        }

        /// <summary>
        /// Brute Force - Recursive
        /// Space : O(m * m) = O(m^2)
        /// Time  : O(m * m^2)
        /// m = target sum, n = length of numbers array
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
