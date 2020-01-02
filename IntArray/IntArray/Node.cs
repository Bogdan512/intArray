using System;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
    public class Node
    {
        readonly int data;

        public Node(int data)
        {
            this.data = data;
        }

        public Node Next { get; set; }

        public Node Previous { get; set; }

        public int GetData()
        {
            return data;
        }
    }
}
