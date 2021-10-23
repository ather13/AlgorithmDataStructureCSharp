﻿using System.Collections.Generic;
using System.Linq;
using AlgonDS._12Tree;

namespace AlgonDS._13TreeProblems
{
    public class TreeMinValueProblem
    {
        public int GetMinValueDfsRecursive(TreeNode<int> root)
        {
            if (root == null) return 0; //assuming there is no zero value in tree node

            var minValue = root.Data;

            var rightMinValue = GetMinValueDfsRecursive(root.Right);
            if (rightMinValue < minValue && rightMinValue != 0)
                minValue = rightMinValue;

            var leftMinValue = GetMinValueDfsRecursive(root.Left);
            if (leftMinValue < minValue && leftMinValue != 0)
                minValue = leftMinValue;

            return minValue;
        }

        public int GetMinValueDfs(TreeNode<int> root)
        {
            if (root == null) return 0;  //assuming there is no zero value in tree node

            var stack = new Stack<TreeNode<int>>();
            stack.Push(root);

            var minValue = int.MaxValue;

            while (stack.Any())
            {
                var current = stack.Pop();

                if (current.Data < minValue)
                    minValue = current.Data;

                if (current.Right != null) stack.Push(current.Right);
                if (current.Left != null) stack.Push(current.Left);
            }

            return minValue;
        }

        public int GetMinValueBfs(TreeNode<int> root)
        {
            if (root == null) return 0; //assuming there is no zero value in tree node

            var minValue = int.MaxValue;
            var queue = new Queue<TreeNode<int>>();
            queue.Enqueue(root);

            while (queue.Any())
            {
                var current = queue.Dequeue();

                if (current.Data < minValue)
                    minValue = current.Data;

                if(current.Left != null) queue.Enqueue(current.Left);

                if (current.Right != null) queue.Enqueue(current.Right);
            }


            return minValue;
        }
    }
}
