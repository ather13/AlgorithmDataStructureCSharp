﻿using System.Collections.Generic;
using System.Linq;

namespace AlgonDS._12Tree
{
    public class DepthFirstSearchInOrder
    {
        /// <summary>
        /// 
        /// </summary>
        public List<char> TraverseIterative(TreeNode<char> root)
        {
            if (root == null) return new List<char>();

            var list = new List<char>();
            var stack = new Stack<TreeNode<char>>();
            
            var current = root;
            while (current != null)
            {
                while (current.Left != null)    // a, b //null
                {
                    stack.Push(current);
                    current = current.Left;
                }
            
                list.Add(current.Data); // d //e //c //f

                while (current.Right == null && stack.Any())
                {
                    current = stack.Pop();  // b // a
                    list.Add(current.Data); //b // a
                }

                current = current.Right; //e //c //f
            }
            
            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        public List<char> TraverseRecursively(TreeNode<char> root)
        {
            if (root == null) return new List<char>();

            var list = new List<char>();
            
            list.AddRange(TraverseRecursively(root.Left));
            list.Add(root.Data);
            list.AddRange(TraverseRecursively(root.Right));

            return list;
        }
    }
}
