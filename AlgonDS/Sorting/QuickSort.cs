/// <summary>
/// Problem Statement :  
///QuickSort is one of the most efficient sorting algorithms and is based on 
///the splitting of an array into smaller ones.The name comes from the fact that,
///quick sort is capable of sorting a list of data elements significantly faster
///than any of the common sorting algorithms.And like Merge sort,
///Quick sort also falls into the category of divide and conquer approach of 
///problem-solving methodology.
/// Examples :  
/// </summary>
using System.Collections.Generic;

namespace AlognDS
{
    public class QuickSort
    {   
        public void GetSortedList(List<int> unsorted, int begin, int end)
        {
            int pivot = unsorted[(begin + (end - begin) / 2)];
            int left = begin;
            int right = end;
            while (left <= right)
            {
                while (unsorted[left] < pivot)
                {
                    left++;
                }
                while (unsorted[right] > pivot)
                {
                    right--;
                }
                if (left <= right)
                {
                    int temp = unsorted[left];
                    unsorted[left] = unsorted[right];
                    unsorted[right] = temp;
                    left++;
                    right--;
                }
            }
            if (begin < right)
            {
                GetSortedList(unsorted, begin, right);
            }
            if (end > left)
            {
                GetSortedList(unsorted, left, end);
            }
        }
    }
}