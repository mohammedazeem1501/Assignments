using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_02
{
    class Ques_04
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Sum (int a, int b, int c)
        {
            return a + b + c;
        }
        public float Sum(float a, float b)
        {
            return a + b;
        }
         public float Sum(int a, float b)
        {
            return a + b;
        }
        public virtual int Product(int a, int b) // virtual function which is to be over-rided in the derived class
        {
            return a + b;
        }
    }
    class Ques_02 : Ques_04
    {
        public override int Product(int a, int b) // virtual function is over-rided in this class which is inherited from the base class
        {
            return a * b;
        }
    }
}
