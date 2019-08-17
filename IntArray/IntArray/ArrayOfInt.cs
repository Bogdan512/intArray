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
            this.array[count] = element;
            count++;
            if (count != array.Length)
            {
                return;
            }

            const int doubleInSize = 2;
            Array.Resize(ref this.array, this.array.Length * doubleInSize);
        }

        public int Count()
        {
            return this.array.Length;
        }

        public int Element(int index)
        {
            return this.array[index];
        }

        public void SetElement(int index, int element)
        {
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
        }

        public void Remove(int element)
        {
            int index = IndexOf(element);
            if (index < 0)
            {
                return;
            }

            RemoveAt(index);
        }

        public void RemoveAt(int index)
        {
                ShiftLeft(index);
                Array.Resize(ref this.array, this.array.Length - 1);
        }

        void ShiftRight(int index)
        {
            for (int i = this.array.Length - 1; i > index; i--)
            {
                this.array[i] = this.array[i - 1];
            }
        }

        void ShiftLeft(int index)
        {
            for (int i = index; i < count; i++)
            {
                this.array[i] = this.array[i + 1];
            }
        }
    }
}
