using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Ques11
    {

        //Write a program that asks the user to type an integer N and computes the sum of the cubes from 5 to the power 3 to N the power 3
        static void Main(String[] args)
        {
            Console.WriteLine("Please enter an integer greater than 5");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i=n;i>=5;i--)
            {
                sum = sum + (i * i * i);
               
            }
            Console.WriteLine("Sum of cubes from 5 to {0} = {1}", n, sum);
            Console.ReadKey();
        }
    }
}
