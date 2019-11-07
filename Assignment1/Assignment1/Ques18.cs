using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    //Write a program in C# to accept a word from the user and display the reverse of it.
    class Ques18
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Please enter a word");
            string s = Console.ReadLine();
            string r = null;
            for (int i = s.Length - 1; i >= 0; i--)
                r += s[i];
            Console.WriteLine("Reversed String: " + r);

            //char[] ch = s.ToCharArray();
            //Array.Reverse(ch);
            //string rs = new string(ch);
            //Console.WriteLine("Reversed String: " + rs);


            Console.ReadKey();


        }
    }
}
