using System.Collections.Generic;
using System.Linq;

namespace AlgonDS._12Tree
{
    public class DepthFirstSearchPostOrder
    {
        /// <summary>
        /// 
        /// </summary>
        public List<char> TraverseRecursive(TreeNode<char> root)
        {
            if (root == null) return new List<char>();

            var list = new List<char>();

            list.AddRange(TraverseRecursive(root.Left));
            list.AddRange(TraverseRecursive(root.Right));
            list.Add(root.Data);

            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        public List<char> TraverseIterative(TreeNode<char> root)
        {
            if (root == null) return new List<char>();

            var list = new List<char>();
            var stack = new Stack<TreeNode<char>>();
            var visited = new HashSet<TreeNode<char>>();

            stack.Push(root);

            while (stack.Any())
            {
                if (stack.Peek().Left != null && !visited.Contains(stack.Peek().Left))
                {
                    stack.Push(stack.Peek().Left);
                    continue;
                }

                if (stack.Peek().Right != null && !visited.Contains(stack.Peek().Right))
                {
                    stack.Push(stack.Peek().Right);
                    continue;
                }

                var current = stack.Pop();
                list.Add(current.Data);
                visited.Add(current);
            }

            return list;
        }
    }
}
