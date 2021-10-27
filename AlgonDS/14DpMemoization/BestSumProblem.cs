using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgonDS._14DpMemoization
{
    /// <summary>
    /// Optimization Problem
    /// </summary>
    public class BestSumProblem
    {
        /// <summary>
        /// Brute Force - Recursive
        /// Space : O(m * m) = O(m^2)
        /// Time  : O(n^m * m)
        /// m = target sum, n = length of numbers array
        /// </summary>
        public int[] GetBestSum(int sum, int[] numbers)
        {
            if (sum == 0) return Array.Empty<int>();
            if (sum < 0) return null;

            int[] bestSum = null;

            foreach (var num in numbers)
            {
                var result = GetBestSumMemo(sum - num, numbers);

                if (result != null)
                {
                    var newArray = result.Append(num).ToArray();
                    if (bestSum == null || newArray.Length < bestSum.Length)
                    {
                        bestSum = newArray;
                    }
                }
            }

            return bestSum;
        }

        /// <summary>
        /// Recursive with Memoization
        /// Space : O(m * m) = O(m^2)
        /// Time  : O(n * m^2)
        /// m = target sum, n = length of numbers array
        /// </summary>
        public int[] GetBestSumMemo(int sum, int[] numbers,Dictionary<int,int[]> memo=null)
        {
            memo ??= new Dictionary<int, int[]>();
            if (memo.ContainsKey(sum)) return memo[sum];

            if (sum == 0) return Array.Empty<int>();
            if (sum < 0) return null;

            int[] bestSum = null;

            foreach (var num in numbers)
            {
                var result = GetBestSumMemo(sum - num, numbers, memo);

                if (result != null)
                {
                    var newArray = result.Append(num).ToArray();

                    if (bestSum == null || newArray.Length < bestSum.Length)
                    {
                        bestSum = newArray;
                    }

                    if (!memo.ContainsKey(sum)) memo.Add(sum, bestSum);
                    if (memo.ContainsKey(sum)) memo[sum] = bestSum;
                }
            }

            if (!memo.ContainsKey(sum)) memo.Add(sum, bestSum);
            return memo[sum];
        }
    }
}
