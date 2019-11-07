using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Ques12
    {
        static void Main(String[] args)
        {
            //Write a program in C# to find the multiplication table of the given number till 20.
            Console.WriteLine("Enter the number to print the multiplication table");
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=20;i++)
            {
                Console.WriteLine("{0} * {1} = {2}", n, i, n * i);
            }
            Console.ReadKey();
        }
    }
}
