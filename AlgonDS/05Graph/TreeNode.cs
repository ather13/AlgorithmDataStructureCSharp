using System;
using System.Collections.Generic;
using System.Text;

namespace AlgonDS
{    
    public class TreeNode
    {
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public int Data { get; set; }

        public TreeNode(int data)
        {
            this.Data = data;
        }
    }
}
