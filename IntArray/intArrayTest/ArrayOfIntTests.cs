using System;
using Xunit;

namespace IntArray
{
    public class ArrayOfIntTests

    {
        [Fact]
        public void Count()
        {
            ArrayOfInt ar = new ArrayOfInt();
            ar.Add(10);
            ar.Add(3);
            Assert.Equal(4, ar.Count());
        }

        [Fact]
        public void Element()
        {
            ArrayOfInt ar = new ArrayOfInt();
            ar.Add(10);
            ar.Add(3);
            ar.Add(5);
            Assert.Equal(5, ar.Element(2));
        }

        [Fact]
        public void SetElement()
        {
            ArrayOfInt ar = new ArrayOfInt();
            ar.Add(10);
            ar.Add(3);
            ar.Add(5);
            ar.SetElement(2, 1);
            Assert.Equal(1, ar.Element(2));
        }

        [Fact]
        public void Contains()
        {
            ArrayOfInt ar = new ArrayOfInt();
            ar.Add(10);
            ar.Add(3);
            ar.Add(5);
            Assert.False(ar.Contains(4));
        }

        [Fact]
        public void Return_IndexOf_If_Element_Exists()
        {
            ArrayOfInt ar = new ArrayOfInt();
            ar.Add(10);
            ar.Add(3);
            ar.Add(5);
            Assert.Equal(1, ar.IndexOf(3));
        }

        [Fact]
        public void Return_Minus1_If_Element_Doesnt_Exists()
        {
            ArrayOfInt ar = new ArrayOfInt();
            ar.Add(10);
            ar.Add(3);
            ar.Add(5);
            Assert.Equal(-1, ar.IndexOf(7));
        }

        [Fact]
        public void Insert()
        {
            ArrayOfInt ar = new ArrayOfInt();
            ar.Add(1);
            ar.Add(2);
            ar.Add(4);
            ar.Add(5);
            ar.Add(6);
            ar.Insert(2, 3);
         Assert.Equal(3, ar.Element(2));
        }

        [Fact]
        public void Clear()
        {
            ArrayOfInt ar = new ArrayOfInt();
            ar.Add(1);
            ar.Add(2);
            ar.Add(4);
            ar.Add(5);
            ar.Add(6);
            ar.Clear();
            Assert.Equal(0, ar.Count());
        }

        [Fact]
        public void Remove()
        {
            ArrayOfInt ar = new ArrayOfInt();
            ar.Add(1);
            ar.Add(2);
            ar.Add(1);
            ar.Add(5);
            ar.Add(6);
            ar.Remove(1);
            Assert.Equal(2, ar.Element(0));
        }

        [Fact]
        public void RemoveAt()
        {
            ArrayOfInt ar = new ArrayOfInt();
            ar.Add(1);
            ar.Add(2);
            ar.Add(3);
            ar.Add(4);
            ar.Add(5);
            ar.Add(6);
            ar.Add(7);
            ar.Add(8);
            ar.RemoveAt(5);
            Assert.Equal(5, ar.Element(4));
        }
    }
}