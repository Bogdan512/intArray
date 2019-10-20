using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace IntArrays
{
    public class MyExceptionsTests
    {
        [Fact]
        public void Throws_Exception()
        {
            var me = new MyExceptions();

            Assert.Throws<InvalidOperationException>(() => me.ReadCurrent());
        }
    }
}
