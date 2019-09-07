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
        public void Insert_0_to_Index0()
        {
            SortedIntArray ar = new SortedIntArray();
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
            SortedIntArray ar = new SortedIntArray();
            ar.Add(4);
            ar.Add(2);
            ar.Add(6);
            ar.Add(1);
            ar.Add(5);
            ar.Insert(0, 7);
            int[] expect = { 1, 2, 4, 5, 6, 0, 0, 0 };
            Assert.Equal(1, ar[0]);
        }

        [Fact]
        public void Insert_3_to_Index2()
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

        [Fact]
        public void Insert_7_to_Index2()
        {
            SortedIntArray ar = new SortedIntArray();
            ar.Add(4);
            ar.Add(2);
            ar.Add(6);
            ar.Add(1);
            ar.Add(5);
            ar.Insert(2, 7);
            int[] expect = { 1, 2, 4, 5, 6, 0, 0, 0 };
            Assert.Equal(4, ar[2]);
        }

        [Fact]
        public void Insert_6_to_Index5()
        {
            SortedIntArray ar = new SortedIntArray();
            ar.Add(4);
            ar.Add(2);
            ar.Add(0);
            ar.Add(1);
            ar.Add(5);
            ar.Insert(5, 6);
            int[] expect = { 0, 1, 2, 4, 5, 6, 0, 0, 0 };
            Assert.Equal(6, ar[5]);
        }

        [Fact]
        public void Insert_3_to_Index5()
        {
            SortedIntArray ar = new SortedIntArray();
            ar.Add(4);
            ar.Add(2);
            ar.Add(0);
            ar.Add(1);
            ar.Add(5);
            ar.Insert(5, 3);
            int[] expect = { 0, 1, 2, 4, 5, 0, 0, 0 };
            int count = ar.Count;
            Assert.Equal(5, count);
        }

    }
}
