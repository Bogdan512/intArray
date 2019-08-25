using System;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
    public class SortedIntArray : IntArray
    {
        public SortedIntArray()
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
    }
}
