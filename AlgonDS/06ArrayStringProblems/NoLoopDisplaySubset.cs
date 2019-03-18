
/// <summary>
/// Print all subsets of given number n without using any loop
/// Example : 
/// For given numer of 4
/// {  1  2  3  4  }
/// {  1  2  3  }
/// {  1  2  }
/// {  1  }
/// </summary>

namespace AlgonDS
{
    public class NoLoopDisplaySubset
    {
        public string PrintAll(int num)
        {
            if (num == 0) return "";
            return $"{{ {PrintSubset(num - 1)} {num} }}\n{PrintAll(num - 1)}".TrimEnd('\n');

            string PrintSubset(int subnum)
            {
                if (subnum == 0) return "";
                return $"{PrintSubset(subnum - 1)} {subnum} ";
            }
        }

        
    }
}
