using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Ques19
    {
        static void Main(String[] args)
        {
            //Write a program in C# to accept two words from user and find out if they are same.
            Console.WriteLine("Enter first word");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter second word");
            string s2 = Console.ReadLine();
            //if (s1.Equals(s2))
            //    Console.WriteLine("Both words are same");
            //else
            //    Console.WriteLine("Both words are not same");

            int i = string.Compare(s1, s2, true);
            if (i == 0)
                Console.WriteLine("Both words are same");
            else
                Console.WriteLine("Both words are not same");

            Console.ReadKey();
        }
    }
}
