using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_02
{
    public class Parent
    {
        virtual public void show()
        {
            Console.WriteLine("This is the virtual method for Ques 05.");
        }
        public virtual void SetData()
        {
            Console.WriteLine("This is the virtual method");
        }
    }
   
    class Ques_05 : Parent
    {
        public override void show()
        {
            Console.WriteLine("\nImplementation of the Ques-05");
            Console.WriteLine("this is the over-rided show() which is defined as virtual in the parent class as asked in Ques-05");
        }
        //************ tried to override a virtual method and then declare is as sealed method. 
        public sealed override void SetData()
        {
            Console.WriteLine(" \n\nSealed Method is implemented.....");
            Console.WriteLine("\nThis method is now sealed and cannot be further over-rided");
        }
    }

    class Derived: Ques_05
    {
       // public void SetData()
       //'Ques_05.SetData()'.To make the current member override that implementation, add the override keyword.Otherwise add the new keyword.

    
    }
}
