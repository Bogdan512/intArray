using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace IntArrays
{
    public class SortedIntArrayTests
    {
        [Fact]
        public void Sort()
        {
            SortedIntArray ar = new SortedIntArray();
            ar.Add(4);
            ar.Add(2);
            ar.Add(6);
            ar.Add(1);
            ar.Add(5);
            int[] expect = {1, 2, 4, 5, 6, 0, 0, 0};
            Assert.Equal(expect, ar.GetArray());
        }
    }
}
