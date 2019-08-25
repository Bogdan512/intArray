using System;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
    public class Program
    {
        public static void Main()
        {
            IntArray ar = new IntArray();
            const int a = 1;
            const int b = 2;
            const int d = 4;
            const int e = 5;
            const int f = 6;

            ar.Add(a);
            ar.Add(b);
            ar.Add(d);
            ar.Add(e);
            ar.Add(f);
            ar.Afis();
            Console.WriteLine();
            SortedIntArray sia = new SortedIntArray();
            ar.Afis();

            Console.Read();
        }
    }
}
