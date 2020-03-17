using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1
{
    class Box_Unbox
    {
        public void box()
        {
            int a = 50;
            object obj = a; //Boxing
            a = 60;

            object obj1 = a; //UnBoxing
            int b = (int)obj1;

            Console.WriteLine("Value of int a : " + a);
            Console.WriteLine("Value of the Boxed Object : " + obj);
            Console.WriteLine("Value of unBoxed int b : " + b);
        }
    }
}
