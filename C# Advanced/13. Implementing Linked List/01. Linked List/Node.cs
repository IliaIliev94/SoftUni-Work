using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Linked_List
{
    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }

        public Node()
        {

        }
        public Node(int value) : this()
        {
            this.Value = value;
        }
    }
}
