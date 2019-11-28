using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace IntArrays
{
#pragma warning disable CA1710 // Identifiers should have correct suffix
    public class ReadOnlyList<T> : IList<T>
#pragma warning restore CA1710 // Identifiers should have correct suffix
    {
        private const string MessageInvalidIndex = "Invalid index";
        private const string MessageReadOnly = "List is readOnly";
        private readonly T[] arr;

        public ReadOnlyList(T[] arr)
        {
            Count = arr.Length;
            this.arr = arr;
        }

        public int Count { get; }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public new T this[int index]
        {
            get
            {
                if (index < 0 || index > Count)
                {
                    throw new ArgumentException(MessageInvalidIndex);
                }

                return arr[index];
            }

            set
            {
                throw new NotSupportedException(MessageReadOnly);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return arr[i];
            }
        }

        public bool Contains(T item)
        {
            return IndexOf(item) >= 0;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this.arr[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Add(T item)
        {
            throw new NotSupportedException(MessageReadOnly);
        }

        public void Insert(int index, T item)
        {
            throw new NotSupportedException(MessageReadOnly);
        }

        public void Clear()
        {
            throw new NotSupportedException(MessageReadOnly);
        }

        public bool Remove(T item)
        {
            throw new NotSupportedException(MessageReadOnly);
        }

        public void RemoveAt(int index)
        {
            throw new NotSupportedException(MessageReadOnly);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotSupportedException(MessageReadOnly);
        }

        public void Afis()
        {
            foreach (T i in arr)
            {
                Console.Write(i);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}