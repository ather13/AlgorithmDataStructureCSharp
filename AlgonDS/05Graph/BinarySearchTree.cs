// ReSharper disable once InvalidXmlDocComment
/// <summary>
/// A Binary Search Tree (BST) is a tree in which all the nodes follow the below-mentioned properties −
///The left sub-tree of a node has a key less than or equal to its parent node's key.
///The right sub-tree of a node has a key greater than to its parent node's key.
///Search Operation: - Whenever an element is to be searched, start searching from the root node. 
///Then if the data is less than the key value, search for the element in the left subtree. 
///Otherwise, search for the element in the right subtree.
/// </summary>

namespace AlgonDS
{
    public class BinarySearchTree
    {
        public TreeNode root;

        public void Insert(int data)
        {

            if (root == null)
            {
                root = new TreeNode(data);
                return;
            }

            var current = root;
            var parent = current;
            while (current != null)
            {
                parent = current;
                if (current.Data >= data)
                {
                    current = current.Left;
                    if (current == null)
                    {
                        parent.Left = new TreeNode(data);
                        return;
                    }
                }
                else if (current.Data < data)
                {
                    current = current.Right;
                    if (current == null)
                    {
                        parent.Right = new TreeNode(data);
                        return;
                    }
                }
            }           
        }

        //LRootR
        public void InOrder(TreeNode root)
        {
            if (root == null) return;

            InOrder(root.Left);
            //Debug.WriteLine(root.Data);
            InOrder(root.Right);
        }

        //RootLR
        public void PreOrder(TreeNode root)
        {
            if (root == null) return;

            //Debug.WriteLine(root.Data);
            PreOrder(root.Left);
            PreOrder(root.Right);
        }

        //RootLR
        public void PostOrder(TreeNode root)
        {

            if (root == null) return;

            PostOrder(root.Left);
            PostOrder(root.Right);
            //Debug.WriteLine(root.Data);
        }

        public bool Search(int data)
        {
            var current = root;

            while (current != null)
            {
                if (current.Data == data)
                    return true;

                if (current.Data >= data)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }

            return false;
        }
    }
}
