using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_02
{
    
    class Square 
    {
        int side; // Encapsulation and abstraction is performed by declaring this variable in a private access mode.
        int Square_Area(int s)
        {
            return s * s;
        }
        
        public void Sq_Area()
        {
            Console.WriteLine("Enter the side of the square : \n ");
            int side = int.Parse(Console.ReadLine());
            Console.WriteLine("Area of the Square is : " + Square_Area(side));
        }
    }
   
}
