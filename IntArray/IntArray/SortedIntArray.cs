using System;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
    public class SortedIntArray : IntArray
    {
        public SortedIntArray() : base()
        {
        }

        public void Sort()
        {
            bool swap = true;
            while (swap)
            {
                swap = false;

                for (int j = 0; j < Count - 1; j++)
                {
                    if (GetArray()[j] > GetArray()[j + 1])
                    {
                        swap = true;
                        int temp = GetArray()[j];
                        GetArray()[j] = GetArray()[j + 1];
                        GetArray()[j + 1] = temp;
                    }
                }
            }
        }

        public new void Add(int element)
        {
            base.Add(element);
            Sort();
        }
    }
}
