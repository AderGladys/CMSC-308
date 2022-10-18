using System;
using System.Collections;
using System.Collections.Generic;

namespace CodeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> charList = new List<char>(10) {'S','X','C','O','M','P','U','T','E','R'};

            Console.Write("Enter code: ");
            string code = Console.ReadLine().ToUpper();
            char[] charInput = code.ToCharArray();

            Console.Write("Equivalent Number: ");

            foreach (char c in charInput)
            {
                int num = charList.IndexOf(c);
                if(num >= 0)
                {
                    Console.Write(num);
                }
                else
                {
                    Console.Write("");
                }
            }
        }
    }
}
