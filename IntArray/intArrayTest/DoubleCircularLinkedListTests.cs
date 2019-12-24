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
            DoubleCircularLinkedList list = new DoubleCircularLinkedList();
            list.AddNode(3);
            list.AddNode(5);
            list.AddNode(7);
        }
    }
}
