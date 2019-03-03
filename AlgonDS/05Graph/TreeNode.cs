using System;
using System.Collections.Generic;
using System.Text;

namespace AlgonDS
{    
    public class TreeNode
    {
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public string Value { get; set; }

        public TreeNode Insert(string value)
        {
            return new TreeNode();
        }

        public bool Find(string value)
        {
            return true;
        }
    }
}
