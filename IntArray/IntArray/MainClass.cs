using System;
using System.Collections.Generic;
using System.Text;

namespace IntArray
{
    public class MainClass
    {
        static void Main()
        {
            IntArray ar = new IntArray();
            ar.Add(10);
            ar.Add(3);
            Console.WriteLine(ar.Count());
            Console.WriteLine(ar.Element(0));
            ar.SetElement(0, 5);
            Console.WriteLine(ar.Element(0));
            Console.WriteLine(ar.Contains(5));
            Console.WriteLine(ar.IndexOf(5));
            Console.Read();
        }
    }
}
