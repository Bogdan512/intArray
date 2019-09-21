using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
    public class MyEnumerator : IEnumerator
    {
        readonly object[] enumeratorArray;
        readonly int count;
        private int position = -1;

        public MyEnumerator(object[] enumeratorArray, int count)
        {
            this.enumeratorArray = enumeratorArray;
            this.count = count;
        }

        public object Current => enumeratorArray[position];

        public bool MoveNext()
        {
            position++;
            return position < count;
        }

        public void Reset()
        {
            position = 0;
        }
    }
}
