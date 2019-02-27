using System.IO;
using System;
using System.Linq;
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