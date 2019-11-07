using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    //Write a program in C# to accept a word from the user and display the length of it.
    class Ques17
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Please enter a word");
            string s = Console.ReadLine();
            Console.WriteLine("Length of the word entered is " + s.Length);
            Console.ReadKey();
        }
    }
}
