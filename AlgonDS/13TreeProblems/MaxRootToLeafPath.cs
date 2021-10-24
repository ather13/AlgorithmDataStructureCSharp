using System;
using AlgonDS._12Tree;

namespace AlgonDS._13TreeProblems
{
    public class MaxRootToLeafPath
    {
        /// <summary>
        /// Find max sum of node from root to leaf 
        /// </summary>
        public int GetMaxRootToLeafPath(TreeNode<int> root)
        {
            if (root == null) return 0;

            var maxValue =  Math.Max(GetMaxRootToLeafPath(root.Right),  GetMaxRootToLeafPath(root.Left));

            return maxValue + root.Data;
        }
    }
}
