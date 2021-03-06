﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
    public class Program
    {
        public static void Main()
        {
            const int aa = 0;
            const int a = 1;
            const int b = 2;
            const int c = 3;
            const int d = 4;
            const int e = 5;
            const int f = 6;
            const int g = 7;

            SortedList<int> ar = new SortedList<int>();

            ar.Add(d);
            ar.Add(b);
            ar.Add(f);
            ar.Add(a);
            ar.Add(e);

            ar.Afis();
            Console.WriteLine();

            foreach (int i in ar)
            {
                Console.Write(i);
            }

            var first = new Student("bob");
            var second = new Student("john");
            Swap(ref first, ref second);

            Console.Read();
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
