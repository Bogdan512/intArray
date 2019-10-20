using System;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
    public class MyExceptions
    {
        readonly int a = 42;
        bool isInitialized;

        public void Initialize()
        {
            isInitialized = true;
        }

        public int ReadCurrent()
        {
            if (!isInitialized)
            {
                throw new InvalidOperationException("Cannot read before initializing.");
            }

            return a;
        }
    }
}
