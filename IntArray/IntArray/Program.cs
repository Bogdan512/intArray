using System;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
    public class Program
    {
        public static void Main()
        {
            ObjectArray ar = new ObjectArray();
            const int aa = 0;
            const int a = 1;
            const int b = 2;
            const int c = 3;
            const int d = 4;
            const int e = 5;
            const int f = 6;
            const int g = 7;
            IList<int> il = new IList<int>;
            ar.Add(d);
            ar.Add(b);
            ar.Add(f);
            ar.Add(a);
            ar.Add(e);

            foreach (int obj in ar)
            {
                Console.Write(obj);
            }

            Console.Read();
        }
    }
}
