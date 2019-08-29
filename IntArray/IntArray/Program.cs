using System;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
    public class Program
    {
        public static void Main()
        {
            SortedIntArray ar = new SortedIntArray();
            const int aa = 0;
            const int a = 1;
            const int b = 2;
            const int c = 3;
            const int d = 4;
            const int e = 5;
            const int f = 6;

            ar.Add(d);
            ar.Add(b);
            ar.Add(f);
            ar.Add(a);
            ar.Add(e);
            ar.Afis();
            Console.WriteLine();
            ar.Insert(b, c);
            ar.Afis();
            Console.Read();
        }
    }
}
