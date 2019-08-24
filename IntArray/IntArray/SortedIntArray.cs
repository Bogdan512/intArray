using System;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
    public class SortedIntArray : IntArray
    {
        readonly int[] arr;

        public SortedIntArray() : base()
        {
            this.arr = GetArray();
        }

        public int[] Sort()
        {
            bool swap = true;
            while (swap)
            {
                swap = false;

                for (int j = 0; j < this.arr.Length - 1; j++)
                {
                    if (this.arr[j] > this.arr[j + 1])
                    {
                        swap = true;
                        int temp = arr[j];
                        this.arr[j] = this.arr[j + 1];
                        this.arr[j + 1] = temp;
                    }
                }
            }

            return this.arr;
        }
    }
}
