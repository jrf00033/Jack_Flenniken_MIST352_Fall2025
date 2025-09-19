/*
 Author: Jack Flenniken
 Date: 9/18/2025
 Purpose: To create a P.O.S. where the user inputs items and prices
 */

namespace In_Class_Task3_POS_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print a prompt asking for the number of items
            Console.WriteLine("How many items are in this order?");
            //Receiving inputs
            int intItemCount = int.Parse(Console.ReadLine());

            //declaring array and setting the number of instances to the number of Items counted
            double[] dblPrices = new double[intItemCount];
            string[] strNames = new string[intItemCount];
            int[] intQty = new int[intItemCount];
            int[] intStocks = new int[intItemCount];
            double[] dblLineTotals = new double[intItemCount];
            double[] dblLinDiscounts = new double[intItemCount];
            Boolean[] boolReorder = new Boolean[intItemCount];
            double dblGross = 0;

            for (int i = 0; i < intItemCount; i++)
            {
                
                Console.WriteLine("Enter Product Name:");
                strNames[i] = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(strNames[i]))
                {
                    return;
                }

                Console.WriteLine("Enter unit price:");
                dblPrices[i] = double.Parse(Console.ReadLine());

                if (dblPrices[i] < 0)
                {
                    return;
                }

                Console.WriteLine("Enter quantity:");
                intQty[i] = int.Parse(Console.ReadLine());

                if (intQty[i] < 0)
                {
                    return;
                }

                
                Console.WriteLine("Enter stock on hand:");
                intStocks[i] = int.Parse(Console.ReadLine());
                if (intStocks[i] < 0)
                {
                    return;
                }
 
                
            }


            for (int i = 0; i < intItemCount; i++)
            {
                dblGross = (dblPrices[i] * intQty[i]);
                
            }

            Console.WriteLine(intQty);
             
        }
    }
}
