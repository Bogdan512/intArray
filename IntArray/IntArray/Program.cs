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
            const int a = 1;
            const int b = 2;
            const int d = 4;
            const int e = 5;
            const int f = 6;

            ar.Add(d);
            ar.Add(b);
            ar.Add(e);
            ar.Add(f);
            ar.Add(a);
            ar.Afis();

            Console.Read();
        }
    }
}
