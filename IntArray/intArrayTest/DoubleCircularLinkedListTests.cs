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
        public void AddAfter_ArgumentException_NodeToInsertAfter_Null_Test__Int()
        {
            var list = new DoubleCircularLinkedList<int>();

            Node<int> nodeList = list.Last;
            Node<int> newNode = new Node<int>(1);

            var exception = Assert.Throws<ArgumentException>(() => list.AddAfter(nodeList, newNode));
            Assert.Equal("Node to insert after is null", exception.Message);
        }

        [Fact]
        public void AddAfter_ArgumentException_NodeToInsert_Null_Test__Int()
        {
            var list = new DoubleCircularLinkedList<int> { 1, 2, 3, 5};

            Node<int> nodeList = list.Last.Previous;
            Node<int> newNode = null;

            var exception = Assert.Throws<ArgumentException>(() => list.AddAfter(nodeList, newNode));
            Assert.Equal("Node to insert is null", exception.Message);
        }

        [Fact]
        public void AddAfter_InvalidOperationException_NodeToInsertAfter_Test__Int()
        {
            var list1 = new DoubleCircularLinkedList<int> { 1, 2, 3, 5 };
            var list2 = new DoubleCircularLinkedList<int> { 1, 2, 3, 4 };

            Node<int> nodeList1 = list1.Last.Previous;
            Node<int> nodeList2 = list2.Last;
            Node<int> newNode = new Node<int>(4);

            var exception = Assert.Throws<InvalidOperationException>(() => list1.AddAfter(nodeList2, newNode));
            Assert.Equal("Node to  insert after is not member of list", exception.Message);
        }

        [Fact]
        public void AddAfter_InvalidOperationException_NodeToInsert_Test__Int()
        {
            var list1 = new DoubleCircularLinkedList<int> { 1, 2, 3, 5 };
            var list2 = new DoubleCircularLinkedList<int> { 1, 2, 3, 4 };

            Node<int> nodeList1 = list1.Last.Previous;
            Node<int> nodeList2 = list2.Last;

            var exception = Assert.Throws<InvalidOperationException>(() => list1.AddAfter(nodeList1, nodeList2));
            Assert.Equal("Node to insert is member of another list", exception.Message);
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
            int[] arr = new int[8];
            int [] array = {0, 0, 0, 1, 2, 3, 4, 5};
            list.CopyTo(arr, 3);
            Assert.Equal(array, arr);
        }

        [Fact]
        public void CopyTo_Test_Strings()
        {
            var list = new DoubleCircularLinkedList<string> { "a", "b", "c", "d", "e" };
            string[] arr = new string[10];
            string[] array = { null, null, "a", "b", "c", "d", "e", null, null, null };
            list.CopyTo(arr, 2);
            Assert.Equal(array, arr);
        }

        [Fact]
        public void CopyTo_ArgumentNullException_Strings()
        {
            var list = new DoubleCircularLinkedList<string> { "a", "b", "c", "d", "e" };

            string[] array = null;

            var exception = Assert.Throws<ArgumentNullException>(() => list.CopyTo(array, 2));
            Assert.Equal("Value cannot be null.\r\nParameter name: index", exception.Message);
        }

        [Fact]
        public void CopyTo_ArgumentOutOfRangeException_IndexSmaller_Than_Zero()
        {
            var list = new DoubleCircularLinkedList<string> { "a", "b", "c", "d", "e" };

            string[] array = new string[5];

            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => list.CopyTo(array, -1));
            Assert.Equal("Specified argument was out of the range of valid values.\r\nParameter name: index", exception.Message);
        }

        [Fact]
        public void CopyTo_ArgumentOutOfRangeException_IndexBigger_Than_ArrayLength()
        {
            var list = new DoubleCircularLinkedList<string> { "a", "b", "c"};

            string[] array = new string[5];

            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => list.CopyTo(array, 6));
            Assert.Equal("Specified argument was out of the range of valid values.\r\nParameter name: index", exception.Message);
        }

        [Fact]
        public void CopyTo_ArgumentException_Strings()
        {
            var list = new DoubleCircularLinkedList<string> { "a", "b", "c", "d", "e" };

            string[] array = new string[7];

            var exception = Assert.Throws<ArgumentException>(() => list.CopyTo(array, 3));
            Assert.Equal("Array length too small", exception.Message);
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
        public void Remove_Value_False()
        {
            var list = new DoubleCircularLinkedList<string> { "a", "b", "c" };

            Assert.False(list.Remove("d"));
        }

        [Fact]
        public void Remove_Value_True()
        {
            var list = new DoubleCircularLinkedList<string> { "a", "b", "c", "d", "e" };
            var Expectedlist = new DoubleCircularLinkedList<string> { "a", "b", "c", "e" };
;
            Assert.True(list.Remove("d"));
        }

        [Fact]
        public void Remove_Node_ArgumentNullException()
        {
            var list = new DoubleCircularLinkedList<string>{"a", "c", "d"};

            Node<string> nullNode = null;

            var exception = Assert.Throws<ArgumentNullException>(() => list.Remove(nullNode));

            Assert.Equal("Value cannot be null.\r\nParameter name: node", exception.Message);
        }

        [Fact]
        public void Remove_Node_InvalidOperationException()
        {
            var list1 = new DoubleCircularLinkedList<string> { "a", "b", "c" };
            var list2 = new DoubleCircularLinkedList<string> { "a", "b", };

            var exception = Assert.Throws<InvalidOperationException>(() => list1.Remove(list2.Last));
            Assert.Equal("Node to remove is not member of list", exception.Message);
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
