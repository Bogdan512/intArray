using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace IntArrays
{
    public class SortedListTests
    {
        [Fact]
        public void Add()
        {
            SortedList<int> ar = new SortedList<int>();
            ar.Add(4);
            ar.Add(2);
            ar.Add(6);
            ar.Add(1);
            ar.Add(5);
            int[] expect = { 1, 2, 4, 5, 6, 0, 0, 0 };
            Assert.Equal(expect[0], ar[0]);
        }

        [Fact]
        public void Insert_0_to_Index0()
        {
            SortedList<int> ar = new SortedList<int>();
            ar.Add(4);
            ar.Add(2);
            ar.Add(6);
            ar.Add(1);
            ar.Add(5);
            ar.Insert(0, 0);
            int[] expect = { 0, 1, 2, 4, 5, 6, 0, 0, 0 };
            Assert.Equal(0, ar[0]);
        }

        [Fact]
        public void Insert_7_to_Index0()
        {
            SortedList<int> ar = new SortedList<int>();
            ar.Add(4);
            ar.Add(2);
            ar.Add(6);
            ar.Add(1);
            ar.Add(5);
            ar.Insert(0, 7);
            int[] expect = { 1, 2, 4, 5, 6, 0, 0, 0 };
            Assert.Equal(1, ar[0]);
        }
    }
}
