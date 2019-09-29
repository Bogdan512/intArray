using System;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
     class SortedList : IComparable<SortedList>
    {
        public int Value { get; set; }

        public int CompareTo(SortedList other)
        {
            return Value.CompareTo(other.Value);
        }
    }
}
