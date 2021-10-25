using System.Collections.Generic;
using System.Linq;

namespace AlgonDS._12Tree
{
    public class DepthFirstSearchPreOrder
    {
        /// <summary>
        /// DFS Traversal - PreOrder using Iterative : Root-Left-Right
        /// </summary>
        public List<char> DfsTraverse_PreOrder(TreeNode<char> root)
        {
            if (root == null) return new List<char>();

            var list = new List<char>();
            var stack = new Stack<TreeNode<char>>();

            stack.Push(root);

            while (stack.Any())
            {
                var current = stack.Pop();

                list.Add(current.Data); 

                if (current.Right != null) stack.Push(current.Right);

                if (current.Left != null) stack.Push(current.Left);
            }

            return list;
        }

        /// <summary>
        /// DFS Traversal - PreOrder using Recursive : Root-Left-Right
        /// </summary>
        public List<char> DfsTraverseRecursive_PreOrder(TreeNode<char> root)
        {
            if (root == null) return new List<char>();

            var list = new List<char> { root.Data };

            list.AddRange(DfsTraverseRecursive_PreOrder(root.Left));

            list.AddRange(DfsTraverseRecursive_PreOrder(root.Right));

            return list;
        }
    }
}
