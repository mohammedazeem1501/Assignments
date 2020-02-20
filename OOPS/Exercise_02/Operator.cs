using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_02
{
    class Operator
    {
        public int number = 0;
        public Operator() { }
        public Operator(int n)
        {
            number = n;
        }
        public static Operator operator +(Operator op1, Operator op2)
        {
            Operator op3 = new Operator(0);
            op3.number = op1.number * op2.number;
            return op3;
           
        }
        public void Display()
        {
            Console.WriteLine("The + operator will give you the product of the two numbers : " + number);
        }

    }
}
