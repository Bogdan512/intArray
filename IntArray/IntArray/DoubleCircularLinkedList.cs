﻿using System;
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

        public void Remove(Node<T> node)
        {
            if (Find(node.GetData()) == null)
            {
                return;
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
