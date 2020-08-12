using System;
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

            Assert.Equal("a", d[1]);
        }
    }
}
