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
            DoubleCircularLinkedList list = new DoubleCircularLinkedList(5);
            Node current = list.GetCurrent();

            Assert.Same(current.Next, current.Previous);
        }
    }
}
