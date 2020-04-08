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

        public Node<T> First
        {
            get
            {
                Node<T> node = root.Next;
                if (Count == 0)
                {
                    return null;
                }

                return node;
            }
        }

        public Node<T> Last
        {
            get
            {
                Node<T> node = root.Previous;
                if (Count == 0)
                {
                    return null;
                }

                return node;
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

        public bool Contains(T value)
        {
            for (Node<T> node = root.Next; node != root; node = node.Next)
            {
                if (node.GetData().Equals(value))
                {
                    return true;
                }
            }

            return false;
        }

        public Node<T> Parcurge(Node<T> node1)
        {
            for (Node<T> node = root; node.Next != root; node = node.Next)
            {
                if (node.GetData().Equals(node1.GetData()))
                {
                    return node;
                }
            }

            return root;
        }

        public void AddAfter(Node<T> node1, Node<T> node2)
            {
            Node<T> node = Parcurge(node1);
            if (!node.GetData().Equals(node1.GetData()))
            {
                return;
            }

            node2.Next = node.Next;
            node.Next = node2;
            node2.Next.Previous = node2;
            node2.Previous = node;
        }

        public void AddBefore(Node<T> node1, Node<T> node2)
        {
            AddAfter(node1, node2);
        }

        public void AddFirst(Node<T> node1)
        {
            AddAfter(root, node1);
        }

        public void AddLast(T value)
        {
            Add(value);
        }

        public void Clear()
        {
            root.Next = root;
            root.Previous = root;
            Count = 0;
        }

        public void CopyTo(T[] array, int index)
        {
            int i = 0;
            if (index < 0 || index > Count)
            {
                throw new ArgumentException("Index is smaller or bigger then count");
            }

            if (array.Length < Count - index - 1)
            {
                throw new OverflowException("Array length too small");
            }

            for (Node<T> node = root.Next; node != root; node = node.Next)
            {
                if (i >= index)
                {
                    array[i - index + 1] = node.GetData();
                }

                i++;
            }
        }

        public Node<T> Find(T value)
        {
            for (Node<T> node = root.Next; node != root; node = node.Next)
            {
                if (node.GetData().Equals(value))
                {
                    return node;
                }
            }

            return null;
        }

        public Node<T> FindLast(T value)
        {
            Node<T> noode = null;
            for (Node<T> node = root.Next; node != root; node = node.Next)
            {
                if (node.GetData().Equals(value))
                {
                    noode = node;
                }
            }

            return noode;
        }

        public void Remove(T value)
        {
            if (!Contains(value))
            {
                return;
            }

            for (Node<T> node = root.Next; node != root; node = node.Next)
            {
                if (node.GetData().Equals(value))
                {
                    node.Previous.Next = node.Next;
                    node.Next.Previous = node.Previous;
                }
            }
        }

        public void RemoveFirst()
        {
            First.Next.Previous = Last;
            Last.Previous = First.Next.Previous;
        }

        public void RemoveLast()
        {
            Last.Previous.Next = root;
            root.Previous = Last.Previous.Next;
        }
    }
}
