/// <summary>
/// Problem Statement :  divide an array into sub arrays based on given size 
/// Examples : 
/// Arr: {1,2,3,4}, Size: 2 => {1,2} {3,4}
/// Arr: {1,2,3,4,5}, Size: 3 => {1,2,3} {4,5}
/// Arr: {1,2,3,4}, Size: 5 => {1,2,3,4}
/// </summary>

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AlgonDS
{
    public class ChunkOfArray
    {
        //option 3 - using linq
        public List<int[]> GetChunkOfArrays(int[] toBeChunk, int splitSize)
        {
            var chunkedArrayList = new List<int[]>();

            for (int i = 0; i < toBeChunk.Length; i += splitSize)
            {
                chunkedArrayList.Add(toBeChunk.Skip(i).Take(splitSize).ToArray());
            }

            return chunkedArrayList;
        }

        //option 2 - use array.copy
        //public List<int[]> GetChunkOfArrays(int[] toBeChunk, int splitSize)
        //{
        //    List<int[]> chunkedArrayList = new List<int[]>();   

        //    for (int i = 0; i < toBeChunk.Length; i += splitSize)
        //    {
        //        int index = 0;
        //        if (toBeChunk.Length - i >= splitSize)
        //        {
        //            index = splitSize;
        //        }
        //        else
        //        {
        //            index = toBeChunk.Length - i;
        //        }

        //        var chunkedArray = new int[index];
        //        Array.Copy(toBeChunk, i, chunkedArray, 0, index);
        //        chunkedArrayList.Add(chunkedArray);
        //    }

        //    return chunkedArrayList;
        //}

        //option 1 - use list and loop
        //public List<int[]> GetChunkOfArrays(int[] toBeChunk,int splitSize)
        //{
        //    List<int[]> chunkedArrayList = new List<int[]>();            
        //    List<int> chunkedArray = new List<int>();
        //    int counter = 0;

        //    for (int i = 0; i < toBeChunk.Length; i++)
        //    {
        //        chunkedArray.Add(toBeChunk[i]);
        //        counter++;
        //        if (counter == splitSize)
        //        {
        //            chunkedArrayList.Add(chunkedArray.ToArray());
        //            chunkedArray = new List<int>();
        //            counter = 0;
        //        }
        //    }

        //    if (counter!=0) chunkedArrayList.Add(chunkedArray.ToArray());

        //    return chunkedArrayList;
        //}
    }
}
