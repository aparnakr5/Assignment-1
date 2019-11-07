using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Ques8
    {
        static void Main(String[] args)
        {
            //Write a program to print the series: 0,1,4,9,16,.....625
            int a = 0;
            Console.Write(a);
            for (int i=1;a<625;i+=2)
            {
                Console.Write(",");
                a += i;
                Console.Write(a);
                
            }
            Console.ReadKey();
        }
    }
}
