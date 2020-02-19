using System;

namespace Exercise_1
{
    class Program : Access_Mod
    {
        int a = 10;
        public void set() // function to acess different access modifiers in another class
        {
            Console.WriteLine("\n\nNow , you can see the different access modifiers used in a program : \n\n");
            Console.WriteLine("value of private member a : " + a);
            Console.WriteLine("value of public member b : " + b);
            Console.WriteLine("value of protected member c : " + c);
            Console.WriteLine("value of internal member d : " + d);
            Console.WriteLine("value of internal protected member d : " + e);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Program to find a leap year : \n");
            Leap_Year lp = new Leap_Year(); // Leap year class
            lp.Year();

            Console.WriteLine("Program to reverse a string\n");
            Reverse_String rs = new Reverse_String(); // Reverse of a String
            rs.stringReverse();

            Console.WriteLine("Program to check Alphabets as vowel and consonant\n");
            Alpha_Check ac = new Alpha_Check(); // Alphabet checking for vowels and consonants
            ac.check();

            Console.WriteLine("\n\nThis data is fetched by using static and instance variables in a different class :");
            Student obj = new Student(); // Static and Instance variables
            Console.WriteLine("\n\nRoll no : " + obj.roll + "\nName - " + Student.name + " has obtained " + obj.perc + "%....!");

            Console.WriteLine("\n\nThis data is fetched by Boxing and Unboxing the objects \n");
            Box_Unbox bu = new Box_Unbox(); // Boxing and Unboxing
            bu.box();

            Console.WriteLine("\nProgram to generate a table \n");
            Table t = new Table();  // Multiplication table for an Integer
            t.table();


            Program p = new Program(); 
            p.set();  // Access modifiers funnction call



        }
    }
}
