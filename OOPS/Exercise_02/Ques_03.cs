using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_02
{
    interface first // interface 1 having display()
    {
        void display();
    }

    interface second  // interface 2 having same display()
    {
        void display();
    }
    public class Ques_03 : first, second // multiple inheritance by inheriting more than one interfaces in the same class.......!
    {
         void first.display()
        {
            Console.WriteLine("\n\n\n\nThe display()from the class which inherits two interfaces having same name. ");
            Console.WriteLine("The display() from the first interface has been invoked.");
        }
        void second.display()
        {
            Console.WriteLine("\n\n\n\nThe display()from the class which inherits two interfaces having same name. ");
            Console.WriteLine("The display() from the first interface has been invoked.");
        }
    }
}
