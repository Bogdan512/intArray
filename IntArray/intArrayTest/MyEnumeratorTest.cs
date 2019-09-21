using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace IntArrays
{
    public class MyEnumeratorTest
    {
        [Fact]
        public void Current()
        {
            object[] ar = null;
            int count = 0;
            MyEnumerator me = new MyEnumerator(ar,count);
            Assert.Null(me.Current);
        }

        [Fact]
        public void MoveNext()
        {
            object[] ar = null;
            int count = 0;
            MyEnumerator me = new MyEnumerator(ar, count);
            Assert.False(me.MoveNext());
        }
    }
}
