using System;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
    public class SortedIntArray : IntArray
    {
        public new int this[int index]
        {
            get => this[index];
            set
            {
                if (this[index - 1] > value && value > this[index + 1] || index != 0 || index != Count - 1)
                {
                    return;
                }

                this[index] = value;
            }
        }

        public void Sort()
        {
            bool swap = true;
            while (swap)
            {
                swap = false;

                for (int j = 0; j < Count - 1; j++)
                {
                    if (this[j] > this[j + 1])
                    {
                        swap = true;
                        int temp = this[j];
                        this[j] = this[j + 1];
                        this[j + 1] = temp;
                    }
                }
            }
        }

        public new void Add(int element)
        {
            base.Add(element);
            Sort();
        }

        public new void Insert(int index, int element)
        {
            if (this[index - 1] > element && element > this[index + 1] || index != 0 || index != Count - 1)
            {
                return;
            }

            base.Insert(index, element);
        }
    }
}
