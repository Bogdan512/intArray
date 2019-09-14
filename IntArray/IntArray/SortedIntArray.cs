using System;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
    public class SortedIntArray : IntArray
    {
        static bool isNotSet;

        public override int this[int index]
        {
            set
            {
                if (isNotSet)
                {
                    Set(index, value);
                }

                if (GetValueOrDefault(index - 1, value) <= value && value <= GetValueOrDefault(index + 1, value) && !isNotSet)
                {
                    Set(index, value);
                }

                Get();
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
                        isNotSet = true;
                        swap = true;
                        int temp = this[j];
                        this[j] = this[j + 1];
                        this[j + 1] = temp;
                        isNotSet = false;
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
            if (GetValueOrDefault(index - 1, element) > element || element > GetValueOrDefault(index, element))
            {
                return;
            }

            base.Insert(index, element);
        }

        int GetValueOrDefault(int index, int defaultValue)
        {
            return index >= 0 && index < Count ? this[index] : defaultValue;
        }
    }
}
