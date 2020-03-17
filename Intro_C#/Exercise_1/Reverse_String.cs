using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1
{
    class Reverse_String
    {
        public void stringReverse()
        {
            Console.WriteLine("Enter String (full name) : ");
            string str = Console.ReadLine();
            Console.WriteLine("The actual string is : " + str);
            Console.WriteLine("The Reversed String is : " + reverseString(str));
        }
        public string reverseString(string str) // function for reversing a string
        {
            char[] chars = str.ToCharArray(); // converting into a character array
            char[] result = new char[chars.Length];
            for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
            {
                result[i] = chars[j];
            }
            return new string(result);

        }

    }
}
