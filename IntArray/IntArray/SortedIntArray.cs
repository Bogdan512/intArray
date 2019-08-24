using System;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
    public class SortedIntArray : IntArray
    {
        readonly int[] array;

        public SortedIntArray(int[] array)
        {
            this.array = array;
        }

        public int[] Sort()
        {
            bool swap = true;
            while (swap)
            {
                swap = false;

                for (int j = 0; j < this.array.Length - 1; j++)
                {
                    if (this.array[j] > this.array[j + 1])
                    {
                        swap = true;
                        int temp = array[j];
                        this.array[j] = this.array[j + 1];
                        this.array[j + 1] = temp;
                    }
                }
            }

            return this.array;
        }
    }
}
