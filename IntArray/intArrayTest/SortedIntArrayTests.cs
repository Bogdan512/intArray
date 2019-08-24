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
            int[] array = { 4, 2, 6, 1, 5 };
            SortedIntArray sia = new SortedIntArray(array);
            int[] expect = {1, 2, 4, 5, 6};
            Assert.Equal(expect, sia.Sort());
        }
    }
}
