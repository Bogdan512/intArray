using System;
using Xunit;

namespace IntArray
{
    public class IntArrayTests
    {
        [Fact]
        public void AddElement()
        {
            IntArray ar = new IntArray(3);
            ar.Add(10);
            ar.Add(3);
            Assert.Equal(5, ar.Count());
        }
    }
}
