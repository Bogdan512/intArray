using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace IntArrays
{
    public class SortedIntArrayTests
    {
        [Fact]
        public void Add()
        {
            SortedIntArray ar = new SortedIntArray();
            ar.Add(4);
            ar.Add(2);
            ar.Add(6);
            ar.Add(1);
            ar.Add(5);
            int[] expect = {1, 2, 4, 5, 6, 0, 0, 0};
            Assert.Equal(expect[0], ar[0]);
        }

        [Fact]
        public void Insert()
        {
            SortedIntArray ar = new SortedIntArray();
            ar.Add(4);
            ar.Add(2);
            ar.Add(6);
            ar.Add(1);
            ar.Add(5);
            ar.Insert(2, 3);
            int[] expect = { 1, 2, 3, 4, 5, 6, 0, 0, 0 };
            Assert.Equal(3, ar[2]);
        }
    }
}
