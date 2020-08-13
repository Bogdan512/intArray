using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IntOfArrays
{
#pragma warning disable CA1710 // Identifiers should have correct suffix
    public class IntDictionary<TValue> : IDictionary<int, TValue>
#pragma warning restore CA1710 // Identifiers should have correct suffix
    {
        private const string MessageInvalidKey = "Invalid key";
        readonly int[] firstArray;
        readonly DictionaryNode<TValue>[] secondArray;

        public IntDictionary(int size)
        {
            Count = 0;
            firstArray = new int[size];
            secondArray = new DictionaryNode<TValue>[size];
            FirstArray();
        }

        public ICollection<int> Keys { get; }

        public ICollection<TValue> Values { get; }

        public int Count { get; private set; }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public TValue this[int key]
        {
            get
            {
                if (key < 0 || key > Count)
                {
                    throw new ArgumentException(MessageInvalidKey);
                }

                return secondArray[key].GetData();
            }
            set => throw new NotImplementedException();
        }

        public void FirstArray()
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = -1;
            }
        }

        public void Add(int key, TValue value)
        {
            int i = 0;
            while (secondArray[i] != null)
            {
                i++;
            }

            secondArray[i] = new DictionaryNode<TValue>(key, value, -1);
            firstArray[key % firstArray.Length] = i;
            Count++;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(KeyValuePair<int, TValue> item)
        {
            throw new NotImplementedException();
        }

        public bool ContainsKey(int key)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<int, TValue>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<int, TValue>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(int key)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<int, TValue> item)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(int key, out TValue value)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Add(KeyValuePair<int, TValue> item)
        {
            throw new NotImplementedException();
        }
    }
}
