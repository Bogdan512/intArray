using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace IntArrays
{
    public class MyExceptionsTests
    {
        [Fact]
        public void Throws_DivideByZeroException()
        {
            MyExceptions me = new MyExceptions();
            Action testcode = (me.MyDivideByZeroException) => { throw new DivideByZeroException(); }
            Assert.Throws<DivideByZeroException>(me.MyDivideByZeroException());
        }
    }
}
