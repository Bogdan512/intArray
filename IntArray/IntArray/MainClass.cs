using System;
using System.Collections.Generic;
using System.Text;

namespace IntArray
{
    public class MainClass
    {
        static void Main()
        {
            IntArray ar = new IntArray(3);
            ar.Add(10);
            ar.Add(3);
            Console.WriteLine(ar.Count());
            Console.Read();
        }
    }
}
