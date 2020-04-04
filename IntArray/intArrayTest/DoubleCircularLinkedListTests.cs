using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace IntArrays
{
    public class DoubleCircularLinkedListTests
    {
        [Fact]
        public void Add_String()
        {
            var list = new DoubleCircularLinkedList<string> { "a", "b", "c" };
            Assert.Equal(new[] { "a", "b", "c" }, list);
        }

        [Fact]
        public void CountTest()
        {
            var list = new DoubleCircularLinkedList<string> { "a", "b", "c" };
            int count = 3;
            Assert.Equal(count, list.Count);
        }

        [Fact]
        public void First_Test_Strings()
        {
            var list = new DoubleCircularLinkedList<string> { "a", "b", "c" };
            Assert.Equal("a", list.First.GetData());
        }

        [Fact]
        public void Last_Test_Strings()
        {
            var list = new DoubleCircularLinkedList<string> { "a", "b", "c" };
            Assert.Equal("c", list.Last.GetData());
        }

        [Fact]
        public void First_Test_Ints()
        {
            var list = new DoubleCircularLinkedList<int> { 1, 2, 3 };
            Assert.Equal(1, list.First.GetData());
        }

        [Fact]
        public void Last_Test_Ints()
        {
            var list = new DoubleCircularLinkedList<int> { 1, 2, 3 };
            Assert.Equal(3, list.Last.GetData());
        }

        [Fact]
        public void EmptyList_First()
        {
            var list = new DoubleCircularLinkedList<int>();
            Assert.Null(list.First);
        }

        [Fact]
        public void EmptyList_Last()
        {
            var list = new DoubleCircularLinkedList<int>();
            Assert.Null(list.Last);
        }
    }
}
