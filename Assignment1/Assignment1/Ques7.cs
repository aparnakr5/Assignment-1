using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Ques7
    {
        static void Main(String[] args)
        {



            int no;
            Console.WriteLine("How many products did you sell?");
            no = int.Parse(Console.ReadLine());
            int[] prod_no = new int[no];
            int[] quantity = new int[no];
            double prod_price;
            double total = 0d;
            double[] tot = new double[no];
            
            for (int i = 0; i < no; i++)
            {
                Console.WriteLine("Enter product number and  quantity");
                prod_no[i] = int.Parse(Console.ReadLine());
                quantity[i] = int.Parse(Console.ReadLine());

            }


            for (int i = 0; i < no; i++)
                switch (prod_no[i])
                {
                    case 1:
                        prod_price = 22.5d;
                        tot[i] = quantity[i] * prod_price;
                        total = total + (quantity[i] * prod_price);
                        break;
                    case 2:
                        prod_price = 44.5d;
                        tot[i] = quantity[i] * prod_price;
                        total = total + (quantity[i] * prod_price);
                        break;
                    case 3:
                        prod_price = 9.98d;
                        tot[i] = quantity[i] * prod_price;
                        total = total + (quantity[i] * prod_price);
                        break;

                }
            Console.WriteLine("*********************DETAILS*********************");
            for (int i = 0; i < no; i++)
            {

                Console.Write("Product no: {0} Quantity: {1} Bill: {2}", prod_no[i], quantity[i],tot[i]);
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine("*************************************************");
            Console.WriteLine("Total Bill: {0}", total);
            Console.WriteLine("*************************************************");
            Console.ReadKey();

        }
    }
}
