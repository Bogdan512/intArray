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
            root.Head = root;
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

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            AddLast(root.Previous, node);
        }

        public void AddAfter(Node<T> nodeToInsertAfter, T value)
        {
            Node<T> nodeToInsert = new Node<T>(value);
            AddAfter(nodeToInsertAfter, nodeToInsert);
        }

        public void AddAfter(Node<T> nodeToInsertAfter, Node<T> nodeToInsert)
        {
            if (nodeToInsertAfter == null)
            {
                throw new ArgumentException("Node to insert after is null");
            }

            if (nodeToInsert == null)
            {
                throw new ArgumentException("Node to insert is null");
            }

            if (nodeToInsertAfter.Head != root)
            {
                throw new InvalidOperationException("Node to  insert after is not member of list");
            }

            if (nodeToInsert.Head != null)
            {
                throw new InvalidOperationException("Node to insert is member of another list");
            }

            nodeToInsert.Head = root;
            nodeToInsert.Next = nodeToInsertAfter.Next;
            nodeToInsertAfter.Next.Previous = nodeToInsert;
            nodeToInsertAfter.Next = nodeToInsert;
            nodeToInsert.Previous = nodeToInsertAfter;
            Count++;
        }

        public void AddBefore(Node<T> nodeToInsertAfter, T value)
        {
            AddAfter(nodeToInsertAfter.Previous, value);
        }

        public void AddBefore(Node<T> nodeToInsertBefore, Node<T> nodeToInsert)
        {
            AddAfter(nodeToInsertBefore.Previous, nodeToInsert);
        }

        public void AddFirst(T value)
        {
            AddAfter(root, value);
        }

        public void AddFirst(Node<T> nodeToInsert)
        {
            AddAfter(root, nodeToInsert);
        }

        public void AddLast(T value)
        {
            AddAfter(root.Previous, value);
        }

        public void AddLast(Node<T> lastNode, Node<T> nodeToInsert)
        {
            AddAfter(lastNode, nodeToInsert);
        }

        public void Clear()
        {
            root.Next = root;
            root.Previous = root;
            Count = 0;
        }

        public void CopyTo(T[] array, int index)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(index));
            }

            if (index < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            if (index >= array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            if (array.Length - index < Count)
            {
                throw new ArgumentException("Array length too small");
            }

            for (Node<T> node = root.Next; node != root; node = node.Next)
            {
               array[index++] = node.GetData();
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

        public bool Remove(T value)
        {
            Node<T> nodeToRemove = Find(value);

            if (nodeToRemove == null)
            {
                return false;
            }

            nodeToRemove.Previous.Next = nodeToRemove.Next;
            nodeToRemove.Next.Previous = nodeToRemove.Previous;
            Count--;
            return true;
        }

        public void Remove(Node<T> node)
        {
            if (node == null)
            {
                throw new ArgumentNullException(nameof(node));
            }

            if (node.Head != root)
            {
                throw new InvalidOperationException("Node to remove is not member of list");
            }

            node.Previous.Next = node.Next;
            node.Next.Previous = node.Previous;
            Count--;
        }

        public void RemoveFirst()
        {
            Remove(First);
        }

        public void RemoveLast()
        {
            Remove(Last);
        }
    }
}
