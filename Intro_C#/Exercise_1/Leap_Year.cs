using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1
{
    class Leap_Year
    {
        public void Year()
        {
            Console.WriteLine("Enter Year in format(yyyy) : ");
            int year = int.Parse(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                Console.WriteLine("{0} is a Leap Year.", year);
            else
                Console.WriteLine("{0} is not a Leap Year.", year);
            Console.ReadLine();
        }
    }
}
