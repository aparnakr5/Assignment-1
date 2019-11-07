using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Ques10
    {
        static void Main(String[] args)
        {
            //Write a program in C# to generate a Fibonacci series till 40.
            int prev1 = 0;
            int prev2 = 1;
            int curr = prev1+prev2;
            Console.WriteLine("Fibonacci series till 40:");
            Console.Write("{0},{1},{2}", prev1, prev2,curr);
            for(int i=curr;;i++)
            {
                
                
                prev1 = prev2;
                prev2 = curr;
                curr = prev1 + prev2;
                if (curr <= 40)
                {
                    Console.Write(",");
                    Console.Write(curr);
                }
                else
                    break;

            }
            Console.ReadKey();
        }
    }
    
}
