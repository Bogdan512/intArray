﻿using System;
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
            base.Insert(index, element);
            Sort();
        }

        public new void Remove(int element)
        {
            base.Remove(element);
            Sort();
        }

        public new void RemoveAt(int index)
        {
            base.RemoveAt(index);
            Sort();
        }
    }
}
