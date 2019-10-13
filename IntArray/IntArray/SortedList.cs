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
        public override T this[int index]
        {
            set
            {
                if (GetValueOrDefault(index - 1, value).CompareTo(value) > 0 || value.CompareTo(GetValueOrDefault(index + 1, value)) > 0)
                {
                    return;
                }

                base[index] = value;
            }
        }

        public override void Add(T item)
        {
            base.Add(item);
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
                        base[j] = base[j + 1];
                        base[j + 1] = temp;
                    }
                }
            }
        }

        public override void Insert(int index, T item)
        {
            if (GetValueOrDefault(index - 1, item).CompareTo(item) > 0 || item.CompareTo(GetValueOrDefault(index, item)) > 0)
            {
                return;
            }

            base.Insert(index, item);
        }

        T GetValueOrDefault(int index, T defaultValue)
        {
            return index >= 0 && index < Count ? this[index] : defaultValue;
        }
    }
}
