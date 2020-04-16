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
        public void AddAfter_Value_Test_True_Int()
        {
            var list = new DoubleCircularLinkedList<int> { 1, 2, 4 };
            Node<int> doi = list.First.Next;
            int trei = 3;
            list.AddAfter(doi, trei);
            Assert.Equal(3, list.Last.Previous.GetData());
        }

        [Fact]
        public void AddAfter_Test_True_Int()
        {
            var list = new DoubleCircularLinkedList<int> { 1, 2, 4 };
            Node<int> doi = list.First.Next;
            Node<int> trei = new Node<int>(3);
            list.AddAfter(doi, trei);
            Assert.Equal(3, list.Last.Previous.GetData());
        }

        [Fact]
        public void AddAfter_Exception_Test_True_Int()
        {
            var list = new DoubleCircularLinkedList<int> { 1, 2, 4 };
            Node<int> doi = list.First.Next;
            Node<int> trei = null;
            Assert.Throws<ArgumentException>(() => list.AddAfter(doi, trei));
        }

        [Fact]
        public void AddBefore_Value_Test_True_Int()
        {
            var list = new DoubleCircularLinkedList<int> { 1, 2, 4 };
            Node<int> doi = list.First.Next;
            int trei = 3;
            list.AddAfter(doi, trei);
            Assert.Equal(3, list.Last.Previous.GetData());
        }

        [Fact]
        public void AddBefore_Test_True_Int()
        {
            var list = new DoubleCircularLinkedList<int> { 1, 2, 4 };
            Node<int> doi = list.Last;
            Node<int> trei = new Node<int>(3);
            list.AddBefore(doi, trei);
            Assert.Equal(3, list.Last.Previous.GetData());
        }

        [Fact]
        public void AddFirst_Value_Test_True_Int()
        {
            var list = new DoubleCircularLinkedList<int> { 1, 2, 4 };
            int trei = 3;
            list.AddFirst(trei);
            Assert.Equal(3, list.First.GetData());
        }

        [Fact]
        public void AddFirst_Test_String_True()
        {
            var list = new DoubleCircularLinkedList<string> { "b", "c", "d" };
            Node<string> a = new Node<string>("a");
            list.AddFirst(a);
            Assert.Equal("a", list.First.GetData());
        }

        [Fact]
        public void AddLast_Value_Test_True_Int()
        {
            var list = new DoubleCircularLinkedList<int> { 1, 2, 4 };
            int cinci = 5;
            list.AddLast(cinci);
            Assert.Equal(5, list.Last.GetData());
        }

        [Fact]
        public void AddLast_Test_String_True()
        {
            var list = new DoubleCircularLinkedList<string> { "a", "b", "c" };
            Node<string> last = list.Last;
            Node<string> d = new Node<string>("d");
            list.AddLast(last, d);
            Assert.Equal("d", list.Last.GetData());
        }

        [Fact]
        public void Clear_Test()
        {
            var list = new DoubleCircularLinkedList<string> { "a", "b", "c" };
            list.Clear();
            Assert.Empty(list);
        }

        [Fact]
        public void Clear_Test_Int()
        {
            var list = new DoubleCircularLinkedList<int> { 1, 2, 3 };
            list.Clear();
            Assert.Empty(list);
        }

        [Fact]
        public void CopyTo_Test_Int()
        {
            var list = new DoubleCircularLinkedList<int> { 1, 2, 3, 4, 5 };
            int[] arr = new int[3];
            int [] array = {0, 4, 5};
            list.CopyTo(arr, 3);
            Assert.Equal(array, arr);
        }

        [Fact]
        public void CopyTo_Test_Strings()
        {
            var list = new DoubleCircularLinkedList<string> { "a", "b", "c", "d", "e" };
            string[] arr = new string[4];
            string[] array = { null, "c", "d", "e" };
            list.CopyTo(arr, 2);
            Assert.Equal(array, arr);
        }

        [Fact]
        public void Find_Test_True_Int()
        {
            var list = new DoubleCircularLinkedList<int> { 1, 2, 3 };
            Node<int> node = new Node<int>(2);
            Assert.Equal(node.GetData(), list.Find(2).GetData());
        }

        [Fact]
        public void FindLast_Test_Null_Int()
        {
            var list = new DoubleCircularLinkedList<int> { 1, 2, 3 };
            Assert.Null(list.FindLast(4));
        }

        [Fact]
        public void FindLast_Test_True_Int()
        {
            var list = new DoubleCircularLinkedList<int> { 1, 2, 3, 4, 2, 5 };
            Assert.Equal(5, list.FindLast(2).Next.GetData());
        }

        [Fact]
        public void Remove_Test_String_True()
        {
            var list = new DoubleCircularLinkedList<string> { "a", "b", "c" };
            Assert.Equal(3, list.Count);
            list.Remove(list.First.Next);
            Assert.Equal("c", list.First.Next.GetData());
            Assert.Equal(2, list.Count);
        }

        [Fact]
        public void RemoveFirst_Test_String_True()
        {
            var list = new DoubleCircularLinkedList<string> { "a", "b", "c", "d", "e" };
            Assert.Equal(5, list.Count);
            list.RemoveFirst();
            Assert.Equal("b", list.First.GetData());
            Assert.Equal(4, list.Count);
        }

        [Fact]
        public void RemoveLast_Test_String_True()
        {
            var list = new DoubleCircularLinkedList<string> { "a", "b", "c", "d" };
            Assert.Equal(4, list.Count);
            list.RemoveLast();
            Assert.Equal("c", list.Last.GetData());
            Assert.Equal(3, list.Count);
        }
    }
}
