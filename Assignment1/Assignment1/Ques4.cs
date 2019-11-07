using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Ques4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no:");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
                Console.WriteLine("{0} is an EVEN number", n);
            else
                Console.WriteLine("{0} is an ODD number", n);
            Console.ReadKey();
        }
    }

}
