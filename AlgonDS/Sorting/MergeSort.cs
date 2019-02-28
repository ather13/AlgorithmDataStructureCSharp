/// <summary>
/// Problem Statement :  
/// Merge sort is one of the most efficient sorting algorithms. 
/// It works on the principle of Divide and Conquer. 
/// Merge sort repeatedly breaks down a list into several sublists until each 
/// sublist consists of a single element and merging those sublists in a manner 
/// that results into a sorted list.
/// Examples :  
/// </summary>

using System.Collections.Generic;
using System.Linq;

namespace AlgonDS
{
    public class MergeSort
    {
        public List<int> GetSortedList(List<int> unsorted)
        {
            if (unsorted.Count() <= 1) return unsorted;

            int count = unsorted.Count() / 2;
            
            List<int> left = unsorted.GetRange(0, count);

            List<int> right = unsorted.GetRange(count, unsorted.Count() - count);
            
            left = GetSortedList(left);
            right = GetSortedList(right);

            return GetSortedList(left, right);
        }

        List<int> GetSortedList(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count() != 0 || right.Count() != 0)
            {
                if (left.Count() > 0 && right.Count() > 0)
                {
                    if (left.First() > right.First())
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                    else
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                }
                else if (left.Count() > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count() > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;
        }
    }
}
