﻿using System;
using System.Collections.Generic;

namespace IntArray
{
    public class IntArray
    {
        int[] array;
	    public IntArray()
        {
            this.array = new int[0];
        }

        public void Add(int element)
        {
            Array.Resize(ref this.array, this.array.Length + 1);
            this.array[this.array.Length - 1] = element;
        }

        public int Count()
        {
            return this.array.Length;
        }

        public int Element(int index)
        {
            return this.array[index - 1];
        }

        public void SetElement(int index, int element)
        {
            // modifică valoarea elementul de la indexul dat
            this.array[index - 1] = element;
        }

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
