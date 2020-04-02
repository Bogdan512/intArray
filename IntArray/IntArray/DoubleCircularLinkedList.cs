using System;
using System.Collections;
using System.Collections.Generic;

namespace IntArrays
{
#pragma warning disable CA1710 // Identifiers should have correct suffix
    public class DoubleCircularLinkedList<T> : IEnumerable<T>, ICollection
#pragma warning restore CA1710 // Identifiers should have correct suffix
    {
        readonly Node<T> root;

        public DoubleCircularLinkedList()
        {
            Count = 0;
            root = new Node<T>(default(T));
            root.Next = root;
            root.Previous = root;
        }

        public int Count { get; private set; }

        public T First
        {
            get
            {
                if (Count == 0)
                {
                    return default(T);
                }

                return root.Next.GetData();
            }
        }

        public T Last
        {
            get
            {
                if (Count == 0)
                {
                    return default(T);
                }

                return root.Previous.GetData();
            }
        }

        public bool IsSynchronized { get; }

        public object SyncRoot { get; }

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> last = root.Previous;
            node.Next = root;
            root.Previous = node;
            node.Previous = last;
            last.Next = node;
            Count++;
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (Node<T> node = root.Next; node != root; node = node.Next)
            {
                yield return node.GetData();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
