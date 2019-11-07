using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Ques3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first no:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second no:");
            int b = int.Parse(Console.ReadLine());

            if(a<b)
            {
                Console.WriteLine("Numbers between {0} and {1}:", a,b);
                for (int i=a+1;i<b;i++)
                {
                    
                    Console.WriteLine(i);
                }
            }
            else if(a>b)
            {
                Console.WriteLine("Numbers between {0} and {1}:" , b, a);
                for (int i = b + 1; i < a; i++)
                {
                    
                    Console.WriteLine(i);
                }
            }
            else if(a==b)
            {
                Console.WriteLine("Both numbers are same");
            }

            Console.ReadKey();
        }
    }

}
