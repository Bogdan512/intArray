using System;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
    public class MyExceptions
    {
        public void MyDivideByZeroException()
        {
            int a = 1;
            const int b = 5;
            a--;
            int c = a;

            try
            {
               int rez = b / c;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }

        public void MyIndexOutOfRangeException()
        {
            int[] array = { 1, 2, 3, 4, 5 };

            try
            {
                for (int i = 5; i <= array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
