using System;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
    public class SortedList<T>
        where T : IComparable<T>
    {
        public int Value { get; set; }

        public int CompareTo(SortedList<T> other)
        {
            return this.Value.CompareTo(other.Value);
        }
    }
}
