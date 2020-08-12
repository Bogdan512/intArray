using System;
using System.Collections.Generic;
using System.Text;

namespace IntOfArrays
{
    public class DictionaryNode<TValue>
    {
        readonly TValue data;
        readonly int key;
        readonly int nextInt;

        public DictionaryNode(int key, TValue data, int nextInt)
        {
            this.key = key;
            this.nextInt = nextInt;
            this.data = data;
        }

        public DictionaryNode<TValue> Next { get; set; }

        public TValue GetData()
        {
            return data;
        }

        public int GetKey()
        {
            return key;
        }

        public int GetNextInt()
        {
            return nextInt;
        }
    }
}
