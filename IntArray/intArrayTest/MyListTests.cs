using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace IntArrays
{
    public class MyListTests
    {
        [Fact]
        public void Add()
        {
            List<int> or = new List<int>();
            or.Add(4);
            or.Add(2);
            or.Add(6);
            or.Add(1);
            or.Add(5);
            int[] expect = { 4, 2, 6, 6, 5, 0, 0, 0 };
            Assert.Equal(4, or[0]);
        }

        [Fact]
        public void Count()
        {
            List<int> or = new List<int>();
            or.Add(10);
            or.Add(3);
            Assert.Equal(2, or.Count);
        }

        [Fact]
        public void Element()
        {
            List<int> or = new List<int>();
            or.Add(10);
            or.Add(3);
            or.Add(5);
            Assert.Equal(5, or[2]);
        }

        [Fact]
        public void SetElement()
        {
            List<int> or = new List<int>();
            or.Add(10);
            or.Add(3);
            or.Add(5);
            or[2] = 1;
            Assert.Equal(1, or[2]);
        }

        [Fact]
        public void Contains()
        {
            List<int> or = new List<int>();
            or.Add(10);
            or.Add(3);
            or.Add(5);
            Assert.False(or.Contains(4));
        }

        [Fact]
        public void Return_IndexOf_If_Element_Exists()
        {
            List<int> or = new List<int>();
            or.Add(10);
            or.Add(3);
            or.Add(5);
            Assert.Equal(1, or.IndexOf(3));
        }
        [Fact]
        public void Return_Minus1_If_Element_Doesnt_Exists()
        {
            List<int> or = new List<int>();
            or.Add(10);
            or.Add(3);
            or.Add(5);
            Assert.Equal(5, or[2]);
        }

        

        [Fact]
        public void Clear()
        {
            List<int> or = new List<int>();
            or.Add(1);
            or.Add(2);
            or.Add(4);
            or.Add(5);
            or.Add(6);
            or.Clear();
            Assert.Equal(0, or.Count);
        }

        [Fact]
        public void Remove()
        {
            List<int> or = new List<int>();

            or.Add(1);
            or.Add(2);
            or.Add(1);
            or.Add(5);
            or.Add(6);
            or.Remove(1);
            Assert.Equal(2, or[0]);
        }

        [Fact]
        public void RemoveAt()
        {
            List<int> or = new List<int>();
            or.Add(1);
            or.Add(2);
            or.Add(3);
            or.Add(4);
            or.Add(5);
            or.Add(6);
            or.Add(7);
            or.Add(8);
            or.RemoveAt(5);
            Assert.Equal(5, or[4]);
        }
    }
}
