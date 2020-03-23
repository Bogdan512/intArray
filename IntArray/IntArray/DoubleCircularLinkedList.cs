using System;
using System.Collections;
using System.Collections.Generic;

namespace IntArrays
{
#pragma warning disable CA1710 // Identifiers should have correct suffix
    public class DoubleCircularLinkedList<T> : IEnumerable<string>
#pragma warning restore CA1710 // Identifiers should have correct suffix
    {
        readonly Node<T> root;

        public DoubleCircularLinkedList()
        {
            root = new Node<T>(default(T));
            root.Next = root;
            root.Previous = root;
        }

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> last = root.Previous;
            node.Next = root;
            root.Previous = node;
            node.Previous = last;
            last.Next = node;
        }

        public IEnumerator<string> GetEnumerator()
        {
           yield return "a";
           yield return "b";
           yield return "c";
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
