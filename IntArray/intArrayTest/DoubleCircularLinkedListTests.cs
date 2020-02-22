using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace IntArrays
{
    public class DoubleCircularLinkedListTests
    {
        [Fact]
        public void AddNode_String()
        {
            DoubleCircularLinkedList<string> list = new DoubleCircularLinkedList<string>("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");

            Assert.Equal(2, list.GetLocationInList(list, "B", 2));
        }

        [Fact]
        public void AddNode_String_Not_In_List()
        {
            DoubleCircularLinkedList<string> list = new DoubleCircularLinkedList<string>("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");

            Assert.Equal(-1 , list.GetLocationInList(list, "Z", -1));
        }

        [Fact]
        public void AddNode_Int()
        {
            DoubleCircularLinkedList<int> list = new DoubleCircularLinkedList<int>(1);
            list.Add(4);
            list.Add(5);
            list.Add(7);

            Assert.Equal(4, list.GetLocationInList(list, 7, 4));
        }
    }
}
