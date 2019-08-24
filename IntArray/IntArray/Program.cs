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
            SortedIntArray sia = new SortedIntArray(array);
            int[] siaArray = sia.Sort();
            const int a = 3;
            foreach (int i in array)
            {
                Console.Write(i);
            }

            const int nr = 5;
            BinarySearch(array, nr);

            Console.Read();
        }

        public static void BinarySearch(int[] ar, int nr)
        {
            Console.WriteLine(nr + ar[1]);
        }
    }
}
