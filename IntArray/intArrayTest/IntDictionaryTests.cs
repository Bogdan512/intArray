﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace IntOfArrays
{
    public class IntDictionaryTests
    {
        [Fact]
        public void Add()
        {
            IntDictionary<string> d = new IntDictionary<string>(5);

            d.Add(1, "a");
            d.Add(2, "b");
            d.Add(10, "c");
            d.Add(7, "d");
            d.Add(12, "e");

            Assert.Equal("b", d[1]);
        }
    }
}
