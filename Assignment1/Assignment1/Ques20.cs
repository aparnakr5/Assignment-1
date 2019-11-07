using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Ques20
    {
        static void Main(String[] args)
        {
            //Write a program in C# to accept a word and to find out whether the given word is palindrome or not.
            Console.WriteLine("Please enter a word");
            string s = Console.ReadLine();
            string r = null;
            for (int i = s.Length - 1; i >= 0; i--)
                r += s[i];
            int p = string.Compare(s, r, true);
            if (p == 0)
                Console.WriteLine("This word is a palindrome");
            else
                Console.WriteLine("This word is not a palindrome");

            Console.ReadKey();
        }
    }
}
