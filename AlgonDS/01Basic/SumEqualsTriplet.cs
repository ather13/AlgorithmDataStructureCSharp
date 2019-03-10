using System.Collections.Generic;

/// <summary>
/// Given an array and a value, find if there is a triplet in array whose sum is equal 
/// to the given value. If there is such a triplet present in array, then print the triplet
/// and return true. Else return false. 
/// For example, if the given array is {12, 3, 4, 1, 6, 9} and given sum is 24, 
/// then there is a triplet (12, 3 and 9) present in array whose sum is 24.
/// </summary>

namespace AlgonDS
{
    public class SumEqualsTriplet
    {
        public bool FindSumWithSorting(int[] arr, int sumValue)
        {
            new QuickSort().GetSortedArray(arr, 0, arr.Length-1);

            for (int i = 0; i < arr.Length-1; i++)
            {
                var j = i + 1;
                var k = arr.Length - 1;
                while (j < k)
                {
                    if (arr[i] + arr[j] + arr[k] == sumValue)
                        return true;
                    else if (arr[i] + arr[j] + arr[k] > sumValue)
                        k--;
                    else if (arr[i] + arr[j] + arr[k] < sumValue)
                        j++;
                }
            }

            return false;
        }

            public bool FindSum(int[] arr, int sumValue)
        {
            var list = new List<int>();
            bool result = false;
            for (var i = 0; i <= arr.Length - 3; i++)
            {
                for (var j = 1; j <= arr.Length - 2; j++)
                {
                    for (var k = 2; k <= arr.Length - 1; k++)
                    {
                        result = IsSum(arr[i], arr[j], arr[k], sumValue);     
                        if (result) return result;
                    }
                }
            }

            return result;
        }

        private bool IsSum(int num1, int num2, int num3, int sumValue)
        {
            var sum = num1 + num2 + num3;

            if (sum == sumValue)
                return true;
            else
                return false;
        }
    }
}
