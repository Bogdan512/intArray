using System;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
    public class DoubleCircularLinkedList
    {
        readonly Node root;

        public DoubleCircularLinkedList(int rootNode)
        {
            root = new Node(rootNode);
            root.Next = root;
            root.Previous = root;
        }

        public void Add(int data)
        {
            Node node = new Node(data);
            if (root.Next == root)
            {
                root.Next = node;
                root.Previous = node;
                node.Previous = root;
                node.Next = root;
            }
            else
            {
                Node last = root.Previous;
                node.Next = root;
                root.Previous = node;
                node.Previous = last;
                last.Next = node;
            }
        }

        public Node GetRoot()
        {
            return root;
        }
    }
}
