using System.Collections.Generic;
using System.Linq;

namespace AlgonDS._12Tree
{
    public class DepthFirstSearchInOrder
    {
        // work in process
        public List<char> Traverse(TreeNode<char> root)
        {
            if (root == null) return new List<char>();

            var list = new List<char>();
            var stack = new Stack<TreeNode<char>>();
            stack.Push(root);

            while (stack.Any())
            {
                var current = stack.Pop();
                
                if (current.Right != null) stack.Push(current.Right);

                if (current.Left != null) stack.Push(current.Left);
            }

            return list;
        }
    }
}
