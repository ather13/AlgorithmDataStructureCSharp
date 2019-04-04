/// <summary>
/// Distribute N candies among K people
/// Given N candies and K people.In the first turn, the first person gets 1 candy, the second gets 2 candies, and so on till K people.
/// In the next turn, the first person gets K+1 candies, the second person gets k+2 candies and so on. 
/// If the number of candies is less than the required number of candies at every turn, then the person receives the remaining number of candies.
/// 
/// Input: N = 7, K = 4     Output: 1 2 3 1
/// Input: N = 10, K = 3    Output: 5 2 3
/// </summary>
namespace AlgonDS
{
    public class NcandiesKpeople
    {
        //number of candies = c
        //number of persons = p
        public int[] GetCandies(int c, int p)
        {
            //initialize number of array 
            var arr = new int[p];
            //sum of persons
            var sumOfP = 0;
            //initialize the value
            for (var i = 1; i <= p; i++)
            {
                arr[i - 1] = 0;
                sumOfP += i;
            }
            var d = c / sumOfP; //find out how many times candies are extra
            var m = c % sumOfP; //after complete assignment remaining 
            if (d > 0)
            {
                for (var i = 1; i <= p; i++)
                {
                    arr[i - 1] = i * d;
                }
            }

            //remaining values
            for (var i = 1; i <= p; i++)
            {
                if (i > m)
                {
                    arr[i - 1] = arr[i - 1] + m;
                    m = 0;
                }
                else
                {
                    arr[i - 1] = arr[i - 1] + i;
                    m = m - i;
                }
                if (m == 0) break;
            }
            return arr;
        }
    }
}
