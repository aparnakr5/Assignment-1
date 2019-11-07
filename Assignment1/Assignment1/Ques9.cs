using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Ques9
    {
        static void Main(String[] args)
        {
            //Write a program in C# to find the factorial of the given number.
            Console.WriteLine("Enter the number to find the factorial");
            int n = int.Parse(Console.ReadLine());
            int fact=1;
            for (int i=n;i>0;i--)
            {
                fact *= i;
            }
            Console.WriteLine("factorial of {0} = {1}", n, fact);
            
            Console.ReadKey();
        }
    }
}
