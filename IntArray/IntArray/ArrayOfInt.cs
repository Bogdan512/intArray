using System;

namespace IntArray
{
    public class ArrayOfInt
    {
        int[] array;
        int count;

        public ArrayOfInt()
        {
           count = 0;
           const int initialLength = 4;
           array = new int[initialLength];
        }

        public void Add(int element)
        {
            EnsureCapacity();
            this.array[count] = element;
            count++;
        }

        public int Count()
        {
            return count;
        }

        public int Element(int index)
        {
            return index <= count ? this.array[index] : -1;
        }

        public void SetElement(int index, int element)
        {
            if (index > count)
            {
                return;
            }

            this.array[index] = element;
        }

        public bool Contains(int element)
        {
            return IndexOf(element) >= 0;
        }

        public int IndexOf(int element)
        {
            for (int i = 0; i < this.array.Length; i++)
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
            SetElement(index, element);
        }

        public void Clear()
        {
            Array.Resize(ref this.array, 0);
            count = 0;
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
            if (count != array.Length)
            {
                return;
            }

            const int doubleInSize = 2;
            Array.Resize(ref this.array, this.array.Length * doubleInSize);
        }

        void ShiftRight(int index)
        {
            if (index > count)
            {
                return;
            }

            for (int i = this.array.Length - 1; i > index; i--)
            {
                this.array[i] = this.array[i - 1];
            }
        }

        void ShiftLeft(int index)
        {
            if (index > count)
            {
                return;
            }

            for (int i = index; i < this.array.Length - 1; i++)
            {
                this.array[i] = this.array[i + 1];
            }
        }
    }
}
