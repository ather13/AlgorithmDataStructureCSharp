using System;
using System.Collections.Generic;
using System.Text;

namespace AlgonDS
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            this.Data = data;
        }
    }
}
