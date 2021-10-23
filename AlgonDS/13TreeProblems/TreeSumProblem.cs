using System.Collections.Generic;
using System.Linq;
using AlgonDS._12Tree;

namespace AlgonDS._13TreeProblems
{
    public class TreeSumProblem
    {
        public int SumNodesDfsRecursive(TreeNode<int> root)
        {
            if (root == null) return 0;

            var sum = root.Data;

            if (root.Right!= null)
                sum += SumNodesDfsRecursive(root.Right);
            
            if (root.Left != null)
                sum += SumNodesDfsRecursive(root.Left);

            return sum;
        }

        public int SumNodesDfs(TreeNode<int> root)
        {
            if (root == null) return 0;
            
            var stack = new Stack<TreeNode<int>>();
            stack.Push(root);

            var sum = 0;

            while (stack.Any())
            {
                var current = stack.Pop();
                sum += current.Data;

                if (current.Right != null) 
                    stack.Push(current.Right);

                if (current.Left != null)
                    stack.Push(current.Left);

            }

            return sum;
        }

        public int SumNodeBfs(TreeNode<int> root)
        {
            if (root == null) return 0;

            var queue = new Queue<TreeNode<int>>();
            queue.Enqueue(root);

            var sum = 0;

            while (queue.Any())
            {
                var current = queue.Dequeue();
                sum += current.Data;

                if (current.Right != null)
                    queue.Enqueue(current.Right);

                if (current.Left != null)
                    queue.Enqueue(current.Left);
            }

            return sum;
        }
    }
}
