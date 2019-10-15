using System;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
    class Student
    {
        readonly string str;

        public Student(string str)
        {
            this.str = str;
        }

        public void Afis()
        {
            Console.WriteLine(str);
        }
    }
}
