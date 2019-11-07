using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# to accept ten marks and display the following
//	a.	Total
//    b.Average
//    c.Minimum marks
//    d.Maximum marks
//    e.Display marks in ascending order
//    f.Display marks in descending order
        
namespace Assignment1
{
    class Ques16
    {
        static void Main(String[] args)
        {
            int[] marks = new int[10];
            Console.WriteLine("Enter the markes of 10 subjects");
            for (int i = 0; i < 10; i++)
                marks[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Total Marks= " +marks.Sum());
            Console.WriteLine("Average Marks= " + marks.Average());
            Console.WriteLine("Minimum Mark " + marks.Min());
            Console.WriteLine("Maximum Mark " + marks.Max());

            Console.WriteLine("Marks in ascending order");
            Array.Sort(marks);
            foreach (int k in marks)
                Console.WriteLine(k);

            Console.WriteLine("Marks in descending order");
            Array.Reverse(marks);
            foreach (int k in marks)
                Console.WriteLine(k);

            Console.ReadKey();

        }

    }
}
