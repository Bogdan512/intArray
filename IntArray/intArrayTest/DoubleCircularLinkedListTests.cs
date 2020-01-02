using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace IntArrays
{
    public class DoubleCircularLinkedListTests
    {
        [Fact]
        public void AddNode()
        {
            DoubleCircularLinkedList list = new DoubleCircularLinkedList(1);
            list.Add(4);
            list.Add(5);
            list.Add(7);
            Assert.Equal(4, list.GetRoot().Next.GetData());
        }
    }
}
