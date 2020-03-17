using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_02
{
    public class A
    {
        public A()
        {
            Console.WriteLine("\nDefault Constructor A is invoked");
        }
        static A()
        {
            Console.WriteLine("\nStatic Constructor A is invoked");
        }
        public A(int a)
        {
            Console.WriteLine("\nParameterised constructor A is invoked");
        }
    }
    public class B : A
    {
        public B()
        {
            Console.WriteLine("\nDefault Constructor B is invoked");
        }
        static B()
        {
            Console.WriteLine("\nStatic Constructor B is invoked");
        }
        public B(int a) : base(5)
        {
            Console.WriteLine("\nParameterised constructor B is invoked");
        }
    }
    
}
