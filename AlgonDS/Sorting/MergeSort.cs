using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AlgonDS
{
    public class MergeSort
    {
        public List<int> GetSortedList(List<int> unsorted)
        {
            if (unsorted.Count() <= 1) return unsorted;

            int count = unsorted.Count() / 2;

            //Console.WriteLine("...");
            //Console.WriteLine(count);
            //Console.WriteLine(unsorted.Count());

            List<int> left = unsorted.GetRange(0, count);
            //left.ForEach((i) => Console.WriteLine(i));

            List<int> right = unsorted.GetRange(count, unsorted.Count() - count);
            //right.ForEach((i) => Console.WriteLine(i));

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

            //Console.WriteLine("...");
            //result.ForEach((i) => Console.WriteLine(i));
            //Console.WriteLine("...");
            return result;
        }
    }
}
