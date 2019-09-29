using System;
using System.Collections;
using System.Collections.Generic;

namespace IntArrays
{
#pragma warning disable CA1710 // Identifiers should have correct suffix
    public class MyList<T> : IEnumerable
#pragma warning restore CA1710 // Identifiers should have correct suffix
    {
        T[] array;

        public MyList()
        {
            Count = 0;
            const int initialLength = 4;
            array = new T[initialLength];
        }

        public int Count { get; private set; }

        public virtual T this[int index]
        {
            get => this.array[index];
            set => this.array[index] = value;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return array[i];
            }
        }

        public void Add(T element)
        {
            EnsureCapacity();
            this.array[Count] = element;
            Count++;
        }

        public bool Contains(T element)
        {
            return IndexOf(element) >= 0;
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this.array[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Insert(int index, T element)
        {
            Array.Resize(ref this.array, this.array.Length + 1);
            ShiftRight(index);
            array[index] = element;
        }

        public void Clear()
        {
            Array.Resize(ref this.array, 0);
            Count = 0;
        }

        public void Remove(T element)
        {
            int indexOfElement = IndexOf(element);
            if (indexOfElement < 0)
            {
                return;
            }

            RemoveAt(indexOfElement);
        }

        public void RemoveAt(int index)
        {
            ShiftLeft(index);
            Array.Resize(ref this.array, this.array.Length - 1);
        }

        public void Afis()
        {
            foreach (T i in array)
            {
                Console.Write(i);
            }
        }

        void EnsureCapacity()
        {
            if (Count != array.Length)
            {
                return;
            }

            const int doubleInSize = 2;
            Array.Resize(ref this.array, this.array.Length * doubleInSize);
        }

        void ShiftRight(object index)
        {
            for (int i = Count; i > (int)index; i--)
            {
                this.array[i] = this.array[i - 1];
            }
        }

        void ShiftLeft(object index)
        {
            for (int i = (int)index; i < Count - 1; i++)
            {
                this.array[i] = this.array[i + 1];
            }
        }
    }
}
