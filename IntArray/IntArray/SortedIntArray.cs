using System;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
    class SortedIntArray : IntArray
    {
        public SortedIntArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
