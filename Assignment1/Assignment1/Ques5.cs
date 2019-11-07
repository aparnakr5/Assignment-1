using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Ques5
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("How many numbers do you wish to enter?");
            int len = int.Parse(Console.ReadLine());
            int[] n = new int[len];
            Console.WriteLine("Enter "+len+" numbers");
            for (int i=0;i<len;i++)
            {
                n[i] = int.Parse(Console.ReadLine()); 
            }

            int so = 0;
            int se = 0;
            for(int j=0;j<len;j++)
            {
                if (n[j] % 2 == 0)
                    se += n[j];
                else
                    so += n[j];
            }

            Console.WriteLine("Sum of odd numbers entered is {0}", so);
            Console.WriteLine("Sum of even numbers entered is {0}", se);
            Console.ReadKey();
        }
    }
}
