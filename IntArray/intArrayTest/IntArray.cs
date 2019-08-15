using System;
using Xunit;

namespace IntArray
{
    public class IntArrayTests
    {
        [Fact]
        public void Count()
        {
            IntArray ar = new IntArray();
            ar.Add(10);
            ar.Add(3);
            Assert.Equal(2, ar.Count());
        }

        [Fact]
        public void Element()
        {
            IntArray ar = new IntArray();
            ar.Add(10);
            ar.Add(3);
            ar.Add(5);
            Assert.Equal(5, ar.Element(2));
        }

        [Fact]
        public void SetElement()
        {
            IntArray ar = new IntArray();
            ar.Add(10);
            ar.Add(3);
            ar.Add(5);
            ar.SetElement(2, 1);
            Assert.Equal(1, ar.Element(2));
        }

        [Fact]
        public void Contains()
        {
            IntArray ar = new IntArray();
            ar.Add(10);
            ar.Add(3);
            ar.Add(5);
            Assert.False(ar.Contains(4));
        }

        [Fact]
        public void Return_IndexOf_If_Element_Exists()
        {
            IntArray ar = new IntArray();
            ar.Add(10);
            ar.Add(3);
            ar.Add(5);
            Assert.Equal(1, ar.IndexOf(3));
        }

        [Fact]
        public void Return_Minus1_If_Element_Doesnt_Exists()
        {
            IntArray ar = new IntArray();
            ar.Add(10);
            ar.Add(3);
            ar.Add(5);
            Assert.Equal(-1, ar.IndexOf(7));
        }
    }
}
