﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IntArray
{
    public class MainClass
    {
        static void Main()
        {
            IntArray ar = new IntArray();
            Console.WriteLine(ar.Count());
            ar.Add(10);
            ar.Add(3);
            Console.WriteLine(ar.Count());
            Console.WriteLine(ar.Element(2));
            ar.SetElement(2, 5);
            Console.WriteLine(ar.Element(2));
            Console.WriteLine();
            Console.Read();
        }
    }
}
