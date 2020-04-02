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
            Assert.Equal(new[] { "a", "b", "c"}, list);
        }

        [Fact]
        public void CountTest()
        {
            var list = new DoubleCircularLinkedList<string> { "a", "b", "c" };
            int count = 3;
            Assert.Equal(count, list.Count);
        }

        [Fact]
        public void First_Test()
        {
            var list = new DoubleCircularLinkedList<string> { "a", "b", "c" };
            Assert.Equal("a", list.First);
        }

        [Fact]
        public void Last_Test()
        {
            var list = new DoubleCircularLinkedList<string> { "a", "b", "c" };
            Assert.Equal("c", list.Last);
        }

        [Fact]
        public void EmptyList_First()
        {
            var list = new DoubleCircularLinkedList<string> {string.Empty};
            Assert.Empty(list.Last);
        }

        [Fact]
        public void EmptyList_Last()
        {
            var list = new DoubleCircularLinkedList<string>();
            Assert.Null(list.Last);
        }
    }
}
