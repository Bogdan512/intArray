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
            int[] temp = new int[this.array.Length + 1];
            for (int i = 0; i <= this.array.Length; i++)
            {
                if (i < index)
                {
                    temp[i] = this.array[i];
                }

                if (i == index)
                {
                    temp[i] = element;
                }

                if (i > index)
                {
                    temp[i] = this.array[i - 1];
                }
            }

            Array.Resize(ref this.array, this.array.Length + 1);
            this.array = temp;
        }

        public void Clear()
        {
            // șterge toate elementele din șir
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
