using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Ques6
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the temperature in Fahrenheit");
            float f = float.Parse(Console.ReadLine());
            float c = (f - 32) * 5 / 9;
            Console.WriteLine("Temperature in Celsius: "+c);
            Console.ReadKey();
        }
    }
}
