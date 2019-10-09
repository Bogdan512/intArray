using System;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
#pragma warning disable CA1710 // Identifiers should have correct suffix
    public class SortedList<T> : List<T>
#pragma warning restore CA1710 // Identifiers should have correct suffix
        where T : IComparable<T>
    {
        public new void Add(T element)
        {
            base.Add(element);
            Sort();
        }

        public void Sort()
        {
            bool swap = true;
            while (swap)
            {
                swap = false;

                for (int j = 0; j < Count - 1; j++)
                {
                    if (this[j].CompareTo(this[j + 1]) > 0)
                    {
                        swap = true;
                        var temp = this[j];
                        this[j] = this[j + 1];
                        this[j + 1] = temp;
                    }
                }
            }
        }
    }
}
