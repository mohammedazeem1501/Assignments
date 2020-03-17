using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1
{
    class Alpha_Check
    {
        public void check()
        {
            Console.WriteLine("\n\nEnter any character : ");
            char ch = char.Parse(Console.ReadLine().ToLower());
            alphabetCheck(ch);
        }
        public void alphabetCheck(char ch)
        {
            Console.WriteLine("Checking alphabet using if-else statements : \n");
            if ((ch == 'a') || (ch == 'e') || (ch == 'i') || (ch == 'o') || (ch == 'u'))
                Console.WriteLine("vowel");
            else
                Console.WriteLine("Consonant");

            Console.WriteLine("\nChecking Alphabet using Switch Cases: \n");

            switch (ch)
            {
                case 'a':
                    Console.WriteLine("Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonant");
                    break;
            }
        }
    }
}
