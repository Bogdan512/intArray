using System;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
    public class DoubleCircularLinkedList<T>
    {
        readonly Node<T> root;

        public DoubleCircularLinkedList(T rootNode)
        {
            root = new Node<T>(rootNode);
            root.Next = root;
            root.Previous = root;
        }

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (root.Next == root)
            {
                root.Next = node;
                root.Previous = node;
                node.Previous = root;
                node.Next = root;
            }
            else
            {
                Node<T> last = root.Previous;
                node.Next = root;
                root.Previous = node;
                node.Previous = last;
                last.Next = node;
            }
        }

        public Node<T> GetRoot()
        {
            return root;
        }
    }
}
