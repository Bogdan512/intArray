﻿using System;
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
        public void Count()
        {
            var list = new DoubleCircularLinkedList<string> { "a", "b", "c" };
            int count = 3;
            Assert.Equal(count, list.Count);
        }

    }
}
