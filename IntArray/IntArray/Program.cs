using System;

namespace IntArray
{
    public class IntArray
    {
        int[] array;

        public IntArray()
        {
            this.array = new int[0];
        }

        public void Add(int element)
        {
            Array.Resize(ref this.array, this.array.Length + 1);
            this.array[this.array.Length - 1] = element;
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
            for (int i = this.array.Length - 1; i > index; i--)
            {
                this.array[i] = this.array[i - 1];
            }

            SetElement(index, element);
        }

        public void Clear()
        {
            Array.Resize(ref this.array, 0);
        }

        public void Remove(int element)
        {
            // șterge prima apariție a elementului din șir
        }

        public void RemoveAt(int index)
        {
            // șterge elementul de pe poziția dată
        }
    }
}
