using System.Collections.Generic;

namespace AlgonDS._14DpMemoization
{
    /// <summary>
    /// Decision Problem
    /// </summary>
    public class CanSumProblem
    {
        /// <summary>
        /// Brute force - Iterative
        /// </summary>
        public bool CanSumIterative(int sum, int[] numbers)
        {
            if (sum == 0) return true;

            foreach (var num in numbers)
            {
                var tempSum = num;
                while (tempSum < sum)
                {
                    tempSum += num;

                    if (sum == tempSum)
                        return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Brute force - Recursive
        /// Space : O(n^m) - exponential
        /// Time  : O(m)
        /// </summary>
        public bool CanSumRecursive(int sum, int[] numbers)
        {
            if (sum == 0) return true;
            if (sum < 0) return false;

            foreach (var num in numbers)
            {
                if (CanSumRecursive(sum - num, numbers))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Recursive with Memoization
        /// Space : O(m * n)
        /// Time  : O(m)
        /// </summary>
        public bool CanSumRecursiveMemo(int sum, int[] numbers, Dictionary<int, bool> memo=null)
        {
            memo ??= new Dictionary<int, bool>();
            if (memo.ContainsKey(sum)) return memo[sum];
            switch (sum)
            {
                case 0:
                    return true;
                case < 0:
                    return false;
            }

            foreach (var num in numbers)
            {
                if (CanSumRecursiveMemo(sum - num, numbers,memo))
                {
                    memo.Add(sum, true);
                    return true;
                }
            }

            memo.Add(sum,false);
            return false;
        }
    }
}
