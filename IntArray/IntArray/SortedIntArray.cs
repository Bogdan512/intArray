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
            if (index == 0)
            {
                if (element > this[index])
                {
                    return;
                }

                base.Insert(index, element);
                return;
            }

            if (index > 0 && index < Count)
            {
                if (this[index - 1] > element || element > this[index])
                {
                    return;
                }

                base.Insert(index, element);
                return;
            }

            if (element < this[index - 1])
            {
                return;
            }

            base.Insert(index, element);
        }
    }
}
