using System;
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

            List<SortedList> sr = new List<SortedList>();

            sr.Add(new SortedList() { Value = b });
            sr.Add(new SortedList() { Value = e });
            sr.Add(new SortedList() { Value = c });
            sr.Add(new SortedList() { Value = a });
            sr.Add(new SortedList() { Value = d });
            sr.Sort();
            foreach (SortedList element in sr)
            {
                Console.Write(element.Value);
            }

            Console.Read();
        }
    }
}
