using System;
using System.Collections;

namespace IntArray
{
    public class IntArray
    {
        ArrayList array;

        public IntArray()
        {
            this.array = new ArrayList();
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
            // modifică valoarea elementul de la indexul dat
        }

        public bool Contains(int element)
        {
            // întoarce true dacă elementul dat există în șir
        }

        public int IndexOf(int element)
        {
            // întoarce indexul elementului sau -1 dacă elementul nu se
            // regăsește în șir
        }

        public void Insert(int index, int element)
        {
            // adaugă un nou element pe poziția dată
        }

        public void Clear()
        {
            // șterge toate elementele din șir
        }

        public void Remove(int element)
        {
            // șterge prima apariție a elementului din șir	
        }

        public void RemoveAt(int index)
        {
            // șterge elementul de pe poziția dată
        }

    }
}
