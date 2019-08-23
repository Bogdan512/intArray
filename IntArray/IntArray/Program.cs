using System;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
    public class Program
    {
        public static void Main()
        {
            int[] array = { 4, 2, 6, 1, 5 };
            foreach (int i in array)
            {
                Console.Write(i);
            }

            SortedIntArray sia = new SortedIntArray(array);

            Console.WriteLine();

            foreach (int i in array)
            {
                Console.Write(i);
            }

            Console.Read();
        }
    }
}
