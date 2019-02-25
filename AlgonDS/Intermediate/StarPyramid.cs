/// <summary>
/// Problem Statement :  Display pyramid made up of stars 
/// Examples : 
//   *
//  ***
// *****
//*******
/// </summary>
/// 
namespace AlgonDS
{
    public class StarPyramid
    {
        public string GetPyramid(int n,int row=0,string pyramidRow="",string pyramid="")
        {
            if (n == row)
            {
                return pyramid;
            }

            int startRange = n -row- 1;
            int endRange = n +row- 1;

            if ((pyramidRow.Length >= startRange) && (pyramidRow.Length <= endRange))
            {
                pyramid += "#";
            }
            else
            {
                pyramid += " ";
            }

            if (pyramidRow.Length == (n + (n - 1))) row = row + 1;
            
            return GetPyramid(n, row, pyramidRow, pyramid);            
        }
            //option 1 - brute force
        //    public string GetPyramid(int n)
        //{
        //    int innerloopEnd = n + (n - 1);
        //    int startRange = n-1;
        //    int endRange = n-1;
        //    string pyramid=string.Empty;

        //    for (int j = 0; j < n; j++)
        //    {
        //        for (int i = 0; i < innerloopEnd; i++)
        //        {
        //            if ((i >= startRange) && (i <= endRange))
        //            {
        //                pyramid += "#";
        //            }
        //            else
        //            {
        //                pyramid += " ";
        //            }
        //        }

        //        startRange -= 1;
        //        endRange += 1;

        //        if(j<n-1) pyramid +="\n";
        //    }

        //    return pyramid;
        //}
    }
}
