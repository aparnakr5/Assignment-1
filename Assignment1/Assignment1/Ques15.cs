using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Ques15
    {
        static void Main(String[] args)
        {
            //Write a program in C# to find the smallest of five numbers accepted from the user.
            int[] num = new int[5];
            Console.WriteLine("Enter five numbers");
            num[0]=int.Parse(Console.ReadLine());
            num[1] = int.Parse(Console.ReadLine());
            num[2] = int.Parse(Console.ReadLine());
            num[3] = int.Parse(Console.ReadLine());
            num[4] = int.Parse(Console.ReadLine());

            Console.WriteLine("Smallest number is " + num.Min());
            //Console.WriteLine("Largest number is " + num.Max());

            Console.ReadKey();

        }
    }
}
