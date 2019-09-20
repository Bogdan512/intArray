using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
    public class MyEnumerator : IEnumerator
    {
        readonly object[] enumeratorArray;
        private int position = -1;

        public MyEnumerator(object[] enumeratorArray)
        {
            this.enumeratorArray = enumeratorArray;
        }

        public object Current => enumeratorArray[position];

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            position++;
            return position < enumeratorArray.Length;
        }

        public void Reset()
        {
            position = 0;
        }
    }
}
