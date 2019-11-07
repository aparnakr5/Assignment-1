using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Ques13
    {
        static void Main(String[] args)
        {

            Console.WriteLine("Numbers divisible by 7 between 200 and 300 are:");
            //Write a program to print the numbers divisible by 7 between 200 and 300.
            for(int i=200;i<=300;i++)
            {
                if (i % 7 == 0)
                    Console.WriteLine(i);
              
            }
            Console.ReadKey();
        }
    }
}
