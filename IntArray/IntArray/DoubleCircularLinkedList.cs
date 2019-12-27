using System;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
    public class DoubleCircularLinkedList
    {
        readonly Node root;
        readonly Node current;

        public DoubleCircularLinkedList(int rootNode)
        {
            root = new Node(rootNode);
            current = root;
            current.Next = root.Previous;
            current.Previous = root.Next;
        }

        public Node GetCurrent()
        {
            return current;
        }

        public Node GetRoot()
        {
            return root;
        }
    }
}
