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
        public void EmptyList_First_Int()
        {
            var list = new DoubleCircularLinkedList<int>();
            Assert.Null(list.First);
        }

        [Fact]
        public void EmptyList_Last_Int()
        {
            var list = new DoubleCircularLinkedList<int>();
            Assert.Null(list.Last);
        }

        [Fact]
        public void Contains_Test_String_False()
        {
            var list = new DoubleCircularLinkedList<string> { "a", "b", "c"};
            Assert.Equal(false, list.Contains("n"));
        }

        [Fact]
        public void Contains_Test_String_True()
        {
            var list = new DoubleCircularLinkedList<string> { "a", "b", "c" };
            Assert.Equal(true, list.Contains("b"));
        }

        [Fact]
        public void Contains_Test_True_Int()
        {
            var list = new DoubleCircularLinkedList<int> { 1, 2, 3 };
            Assert.Equal(true, list.Contains(3));
        }

        [Fact]
        public void AddAfter_Test_True_Int()
        {
            var list = new DoubleCircularLinkedList<int> { 1, 2, 4 };
            Node<int> doi = new Node<int>(2);
            list.AddAfter(doi, 3);
            Assert.Equal(3, list.Last.Previous.GetData());
        }

        [Fact]
        public void AddBefore_Test_True_Int()
        {
            var list = new DoubleCircularLinkedList<int> { 1, 2, 4 };
            Node<int> patru = new Node<int>(4);
            list.AddBefore(patru, 3);
            Assert.Equal(3, list.Last.Previous.GetData());
        }

        [Fact]
        public void AddFirst_Test_String_True()
        {
            var list = new DoubleCircularLinkedList<string> { "b", "c", "d" };
            list.AddFirst("a");
            Assert.Equal("a", list.First.GetData());
        }

    }
}
