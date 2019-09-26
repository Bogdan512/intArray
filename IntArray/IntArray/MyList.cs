using System;
using System.Collections;
using System.Collections.Generic;

namespace IntArrays
{
#pragma warning disable CA1710 // Identifiers should have correct suffix
    public class MyList<T> : IEnumerable
#pragma warning restore CA1710 // Identifiers should have correct suffix
    {
        readonly List<T> array;

        public MyList()
        {
            array = new List<T>();
        }

        public virtual T this[int index]
        {
            get => this.array[index];
            set => this.array[index] = value;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Count; i++)
            {
                yield return array[i];
            }
        }

        public int Count()
        {
            return array.Count;
        }

        public void Add(T element)
        {
            array.Add(element);
        }

        public bool Contains(T element)
        {
            return array.Contains(element);
        }

        public int IndexOf(T element)
        {
            return array.IndexOf(element);
        }

        public void Insert(int index, T element)
        {
            array.Insert(index, element);
        }

        public void Clear()
        {
            array.Clear();
        }

        public void Remove(T element)
        {
            array.Remove(element);
        }

        public void RemoveAt(int index)
        {
            array.RemoveAt(index);
        }

        public void Afis()
        {
            foreach (T i in array)
            {
                Console.Write(i);
            }
        }
    }
}
