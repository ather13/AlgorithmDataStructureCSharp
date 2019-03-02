/// <summary>
/// Problem Statement : 
/// Examples : 
/// </summary>

using System.Linq;

namespace AlgonDS
{
    public class StepsHash
    {
        //option 3 - recursive
        public string GetStepString(int numOfSteps,int row=0,string stairs="",string steps = "")
        {
            if (numOfSteps==row)
            {
                return steps;
            }

            stairs += stairs.Length <= row ? "#" : " ";

            if (numOfSteps == stairs.Length)
            {
                steps += string.IsNullOrEmpty(steps) ? stairs : $"\n{stairs}";
                stairs = "";
                return GetStepString(numOfSteps, row + 1, stairs,steps);
            }
            else
            {
                return GetStepString(numOfSteps, row, stairs, steps);
            }            
        }

        //option 2 - remove inner loop
        //public string GetStepString(int numOfSteps)
        //{
        //    var steps = string.Empty;
        //    for (int i = 0; i < numOfSteps; i++)
        //    {
        //        var lineStep = (new string('#', i + 1)) + (new string(' ', numOfSteps - i - 1));

        //        steps += string.IsNullOrEmpty(steps) ? lineStep : $"\n{lineStep}";
        //    }

        //    return steps;
        //}

        //option 1 - brute force 
        //public string GetStepString(int numOfSteps)
        //{
        //    var steps = string.Empty;
        //    for (int i = 0; i < numOfSteps; i++)
        //    {
        //        var lineStep = string.Empty;

        //        for (int j = 0; j < numOfSteps; j++)
        //        {
        //            if (j <= i)
        //            {
        //                lineStep += "#";
        //            }
        //            else
        //            {
        //                lineStep += ' ';
        //            }
        //        }

        //        steps += string.IsNullOrEmpty(steps) ? lineStep  : $"\n{lineStep}";
        //    }

        //    return steps;
        //}
    }
}
