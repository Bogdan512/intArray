using System;
using System.Collections.Generic;

namespace IntArray
{
    public class IntArray
    {
        int[] array;
	    public IntArray(int n)
        {
            // construiește noul șir
            this.array = new int[n];
        }

        public void Add(int element)
        {
            // adaugă un nou element la sfârșitul șirului
            Array.Resize(ref this.array, this.array.Length + 1);
            this.array[this.array.Length - 1] = element;
        }

        public int Count()
        {
            // întorce numărul de elemente din șir
            int count = 0;
            for (int i = 0; i < this.array.Length; i++)
            {
                count++;
            }
            return count;
        }

        //public int Element(int index)
        //{
        //    // întoarce elementul de la indexul dat
        //}

        //public void SetElement(int index, int element)
        //{
        //    // modifică valoarea elementul de la indexul dat
        //}

        //public bool Contains(int element)
        //{
        //    // întoarce true dacă elementul dat există în șir
        //}

        //public int IndexOf(int element)
        //{
        //    // întoarce indexul elementului sau -1 dacă elementul nu se
        //    // regăsește în șir
        //}

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
