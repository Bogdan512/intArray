using System;
using System.Collections.Generic;

namespace IntArray
{
    public class IntArray
    {
        List<int> array;

        public IntArray()
        {
            this.array = new List<int>();
        }

        public void Add(int element)
        {
            this.array.Add(element);
        }

        public int Count()
        {
            return this.array.Count;
        }

        public int Element(int index)
        {
            int i = (int)array[index];
            return i;
        }

        public void SetElement(int index, int element)
        {
            this.array[index] = element;
        }

        public bool Contains(int element)
        {
            return this.array.Contains(element) ? true : false;
        }

        public int IndexOf(int element)
        {

            return this.array.IndexOf(element);
        }

        public void Insert(int index, int element)
        {
            this.array.Insert(index,element);
        }

        public void Clear()
        {
            this.array.Clear();
        }

        public void Remove(int element)
        {
            this.array.Remove(element);
        }

        public void RemoveAt(int index)
        {
            this.array.RemoveAt(index);
        }

    }
}
