using System;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
    public class SortedIntArray : IntArray
    {
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
            if (index == Count)
            {
                base.Insert(index, element);
            }

            if (GetValueOrDefault(index, element) <= element)
            {
                return;
            }

            base.Insert(index, element);
        }

        int GetValueOrDefault(int index, int defaultValue)
        {
            return this[index] > defaultValue ? this[index] : defaultValue;
        }
    }
}
