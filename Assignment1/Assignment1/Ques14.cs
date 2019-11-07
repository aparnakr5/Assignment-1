using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Ques14
    {
        static void Main(String[] args)
        {
            //Write a program in C# to find the largest of the given three numbers. Accept the numbers from the users.
            Console.WriteLine("Enter three numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            //if(a>b)
            //{
            //    if (a > c)
            //        Console.WriteLine("{0} is greater", a);
            //    else
            //        Console.WriteLine("{0} is greater", c);
            //}
            //else if(a<b)
            //{
            //    if (b > c)
            //        Console.WriteLine("{0} is greater", b);
            //    else
            //        Console.WriteLine("{0} is greater", c);
            //}
            if(a>b && a>c)
                Console.WriteLine("{0} is greater", a);
            else if (b>a && b>c)
                Console.WriteLine("{0} is greater", b);
            else if(c>a && c>b)
                Console.WriteLine("{0} is greater", c);
            else if(a==b && b==c)
                Console.WriteLine("Numbers are equal");
            Console.ReadKey();
        }
    }
}
