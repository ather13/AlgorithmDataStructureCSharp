using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgonDS._12Tree;

namespace AlgonDS._13TreeProblems
{
    public class SearchNodeInTree
    {
        public bool FindNodeUsingDfsRecursive(TreeNode<char> root,char searchValue)
        {
            if (root == null) return false;

            if (root.Data == searchValue) return true;

            var rightNode = true;
            var leftNode = true;

            if (root.Right != null)
                rightNode = FindNodeUsingDfsRecursive(root.Right, searchValue);

            if (root.Left != null)
                leftNode = FindNodeUsingDfsRecursive(root.Left, searchValue);

            return leftNode || rightNode;

        }

        public bool FindNodeUsingDfs(TreeNode<char> root, char searchValue)
        {
            if (root == null) return false;
            
            var stack = new Stack<TreeNode<char>>();
            stack.Push(root);

            while (stack.Any())
            {
                var current = stack.Pop();

                if (current.Data == searchValue) return true;

                if (current.Right != null) stack.Push(current.Right);

                if (current.Left != null) stack.Push(current.Left);

            }

            return false;
        }

        public bool FindNodeUsingBfs(TreeNode<char> root, char searchValue)
        {
            if (root == null) return false;
            
            var queue = new Queue<TreeNode<char>>();
            queue.Enqueue(root);

            while (queue.Any())
            {
                var current = queue.Dequeue();

                if (current.Data == searchValue) return true;

                if (current.Right != null)
                    queue.Enqueue(current.Right);

                if (current.Left != null)
                    queue.Enqueue(current.Left);
            }

            return false;
        }
    }
}
