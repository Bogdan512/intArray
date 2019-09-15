using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace IntOfArrays
{
    public class ObjectArrayTests
    {
        [Fact]
        public void Add()
        {
            ObjectArray or = new ObjectArray();
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
            ObjectArray or = new ObjectArray();
            or.Add(10);
            or.Add(3);
            Assert.Equal(2, or.Count);
        }

        [Fact]
        public void Element()
        {
            ObjectArray or = new ObjectArray();
            or.Add(10);
            or.Add(3);
            or.Add(5);
            Assert.Equal(5, or[2]);
        }

        [Fact]
        public void SetElement()
        {
            ObjectArray or = new ObjectArray();
            or.Add(10);
            or.Add(3);
            or.Add(5);
            or[2] = 1;
            Assert.Equal(1, or[2]);
        }

        [Fact]
        public void Contains()
        {
            ObjectArray or = new ObjectArray();
            or.Add(10);
            or.Add(3);
            or.Add(5);
            Assert.False(or.Contains(4));
        }

        [Fact]
        public void Return_IndexOf_If_Element_Exists()
        {
            ObjectArray or = new ObjectArray();
            or.Add(10);
            or.Add(3);
            or.Add(5);
            Assert.Equal(1, or.IndexOf(3));
        }
        [Fact]
        public void Return_Minus1_If_Element_Doesnt_Exists()
        {
            ObjectArray or = new ObjectArray();
            or.Add(10);
            or.Add(3);
            or.Add(5);
            Assert.Equal(5, or[2]);
        }

        [Fact]
        public void Insert()
        {
            ObjectArray or = new ObjectArray();
            or.Add(1);
            or.Add(2);
            or.Add(4);
            or.Add(5);
            or.Add(6);
            or[2] = 3;
            Assert.Equal(3, or[2]);
        }

        [Fact]
        public void Clear()
        {
            ObjectArray or = new ObjectArray();
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
            ObjectArray or = new ObjectArray();
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
            ObjectArray or = new ObjectArray();
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
