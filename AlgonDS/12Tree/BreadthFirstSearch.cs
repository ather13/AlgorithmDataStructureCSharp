using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace AlgonDS._12Tree
{
    public class BreadthFirstSearch
    {
        public List<char> BfsTraverse(TreeNode<char> root)
        {
            if (root == null) return new List<char>();

            var list = new List<char>();

            var queue = new Queue<TreeNode<char>>();
            queue.Enqueue(root);

            while (queue.Any())
            {
                var current = queue.Dequeue();

                Debug.WriteLine(current.Data);

                list.Add(current.Data);

                if (current.Left != null) queue.Enqueue(current.Left);

                if (current.Right != null) queue.Enqueue(current.Right);

                
            }

            return list;
        }
    }
}
