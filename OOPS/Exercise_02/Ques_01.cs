using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_02
{
    public abstract class AreaClass // abstract class
    {
        abstract public int Area(); // abstract method which is defined in the derived class
        public void display()
        {
            Console.WriteLine("\n\nThis is display() of abstract method");
        }
    }
    interface Perimeter // interface 
    {
        int Peri(); // method from an interface which is defined in the derived class
    }
}
