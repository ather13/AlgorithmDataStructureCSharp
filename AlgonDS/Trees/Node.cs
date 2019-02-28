using System;
using System.Collections.Generic;
using System.Text;

namespace AlgonDS
{    
    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public string Value { get; set; }

        public Node Insert(string value)
        {
            return new Node();
        }

        public bool Find(string value)
        {
            return true;
        }
    }
}
