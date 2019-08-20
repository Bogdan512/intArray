using System;

namespace IntArray
{
    public class ArrayOfInt
    {
        int[] array;

        public ArrayOfInt()
        {
           Count = 0;
           const int initialLength = 4;
           array = new int[initialLength];
        }

        public int Count { get; private set;  }

        public int this[int index]
        {
            get => this.array[index];
            set => this.array[index] = value;
        }

        public void Add(int element)
        {
            EnsureCapacity();
            this.array[Count] = element;
            Count++;
        }

        public bool Contains(int element)
        {
            return IndexOf(element) >= 0;
        }

        public int IndexOf(int element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this.array[i] == element)
                {
                    return i;
                }
            }

            return -1;
        }

        public void Insert(int index, int element)
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

        public void Remove(int element)
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

        void EnsureCapacity()
            {
            if (Count != array.Length)
            {
                return;
            }

            const int doubleInSize = 2;
            Array.Resize(ref this.array, this.array.Length * doubleInSize);
        }

        void ShiftRight(int index)
        {
            for (int i = Count; i > index; i--)
            {
                this.array[i] = this.array[i - 1];
            }
        }

        void ShiftLeft(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                this.array[i] = this.array[i + 1];
            }
        }
    }
}
