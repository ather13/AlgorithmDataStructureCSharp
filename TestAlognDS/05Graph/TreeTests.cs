using System;
using System.Collections.Generic;
using System.Text;

namespace AlgonDS
{    
    public class TreeTests
    {
        public TreeTests Left { get; set; }
        public TreeTests Right { get; set; }
        public string Value { get; set; }

        public TreeTests Insert(string value)
        {
            return new TreeTests();
        }

        public bool Find(string value)
        {
            return true;
        }
    }
}
