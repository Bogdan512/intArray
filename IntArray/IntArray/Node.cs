using System;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
    public class Node
    {
        internal Node NextNode;
        internal Node PreviousNode;
        internal int Nrofnodes;
        internal int Data;

        public Node(int data)
        {
            Data = data;
            Nrofnodes++;
        }
    }
}
