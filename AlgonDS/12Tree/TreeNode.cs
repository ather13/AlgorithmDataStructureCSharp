﻿namespace AlgonDS._12Tree
{    
    public class TreeNode<T>
    {
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }
        public T Data { get; set; }

        public TreeNode()
        {
            
        }

        public TreeNode(T data)
        {
            this.Data = data;
        }
    }
}
