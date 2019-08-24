using System;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
    public class SortedIntArray : IntArray
    {
        public int[] SortedArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                bool swap = false;

                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        swap = true;
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }

                if (!swap)
                {
                    break;
                }
            }

            return array;
        }
    }
}
