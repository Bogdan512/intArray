using System;
using System.Collections;

namespace IntArrays
{
#pragma warning disable CA1710 // Identifiers should have correct suffix
    public class ObjectArray : IEnumerable
#pragma warning restore CA1710 // Identifiers should have correct suffix
    {
        object[] array;

        public ObjectArray()
        {
            Count = 0;
            const int initialLength = 4;
            array = new object[initialLength];
        }

        public int Count { get; private set; }

        public virtual object this[int index]
        {
            get => this.array[index];
            set => this.array[index] = value;
        }

        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(array, Count);
        }

        public void Add(object element)
        {
            EnsureCapacity();
            this.array[Count] = element;
            Count++;
        }

        public bool Contains(object element)
        {
            return IndexOf(element) >= 0;
        }

        public int IndexOf(object element)
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

        public void Insert(object index, object element)
        {
            Array.Resize(ref this.array, this.array.Length + 1);
            ShiftRight(index);
            array[(int)index] = element;
        }

        public void Clear()
        {
            Array.Resize(ref this.array, 0);
            Count = 0;
        }

        public void Remove(object element)
        {
            int indexOfElement = IndexOf(element);
            if (indexOfElement < 0)
            {
                return;
            }

            RemoveAt(indexOfElement);
        }

        public void RemoveAt(object index)
        {
            ShiftLeft(index);
            Array.Resize(ref this.array, this.array.Length - 1);
        }

        public void Afis()
        {
            foreach (int i in array)
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
