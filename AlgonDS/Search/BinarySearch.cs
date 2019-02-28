/// <summary>
/// Problem Statement :  
///Binary search is an improvement over linear searching that works only 
///if the data in the array are sorted beforehand.
/// Examples :  
/// </summary>

using System.Collections.Generic;

namespace AlgonDS
{
    public class BinarySearch
    {
        public int GetPositionOfItem(IList<int> sortedList, int searchParam, int begin, int end)
        {
            if (begin > end) return -1;

            var mid = (end + begin) / 2;

            if (sortedList[mid] == searchParam)
                return mid;
            else if (sortedList[mid] < searchParam)
            {
                int position = GetPositionOfItem(sortedList, searchParam, mid + 1, end);
                return position;
            }
            else if (sortedList[mid] > searchParam)
            {
                int position = GetPositionOfItem(sortedList, searchParam, begin, mid - 1);
                return position;
            }

            return -1;
        }
    }
}
