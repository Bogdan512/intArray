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
            DoubleCircularLinkedList<int> list = new DoubleCircularLinkedList<int>(1);
            list.Add(4);
            list.Add(5);
            list.Add(7);
        }
    }
}
