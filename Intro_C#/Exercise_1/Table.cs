using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1
{
    class Table
    {
        public void table() // function for printing a table of any integer
        {
            Console.WriteLine("Tables from 1 to 5 \n : ");
            //int num = int.Parse(Console.ReadLine());
            //for (int j = 1; j <= 5; j++)
            //{
            //    Console.WriteLine("table for " + j + " is : \n");
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        Console.WriteLine(j + " X " + i + " : " + j * i);
            //    }
            //}
            int i, j;


            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    // Console.WriteLine("table of" + i + "is: \n");
                    Console.WriteLine(i + " X " + j + " : " + i * j);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
