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
            
            Console.WriteLine("How many items are in this order?"); // Displays prompt to user
            int intItemCount = int.Parse(Console.ReadLine()); // Reads and parses number of items
            double[] dblPrices = new double[intItemCount]; // Stores unit prices
            string[] strNames = new string[intItemCount]; // Stores product names
            int[] intQty = new int[intItemCount]; // Stores quantities
            int[] intStocks = new int[intItemCount]; // Stores stock on hand
            double[] dblLineTotals = new double[intItemCount]; // Stores final line totals after discount
            double[] dblLineDiscounts = new double[intItemCount]; // Stores discount amounts
            Boolean[] boolReorder = new Boolean[intItemCount]; // Stores reorder status
            double[] dblGross = new double[intItemCount]; // Stores gross totals before discount
            int[] intPostSaleStock = new int[intItemCount]; // Stores stock remaining after sale

            for (int i = 0; i < intItemCount; i++) // Loop through each item
            {
                Console.WriteLine("Enter Product Name:"); // Prompt for product name
                strNames[i] = Console.ReadLine(); // Read product name

                if (string.IsNullOrWhiteSpace(strNames[i])) // Check for empty or whitespace name
                {
                    Console.WriteLine("[warn] Invalid Name. Defaulting to null"); // Warn user
                    strNames[i] = "null"; // Default name
                }

                Console.WriteLine("Enter unit price:"); // Prompt for unit price
                dblPrices[i] = double.Parse(Console.ReadLine()); // Read and parse price

                if (dblPrices[i] < 0) // Check for negative price
                {
                    Console.WriteLine("[warn] Invalid Price. Defaulting to 0"); // Warn user
                    dblPrices[i] = 0; // Default price
                }

                Console.WriteLine("Enter quantity:"); // Prompt for quantity
                intQty[i] = int.Parse(Console.ReadLine()); // Read and parse quantity

                if (intQty[i] < 0) // Check for negative quantity
                {
                    Console.WriteLine("[warn] Invalid Quantity. Defaulting to 0"); // Warn user
                    intQty[i] = 0; // Default quantity
                }

                Console.WriteLine("Enter stock on hand:"); // Prompt for stock
                intStocks[i] = int.Parse(Console.ReadLine()); // Read and parse stock

                if (intStocks[i] < 0) // Check for negative stock
                {
                    Console.WriteLine("[warn] Invalid Stock. Defaulting to 0"); // Warn user
                    intStocks[i] = 0; // Default stock
                }
            }

            
            for (int i = 0; i < intItemCount; i++) // Loop through items
            {
                dblGross[i] = (dblPrices[i] * intQty[i]); // Calculate gross total

                if (intQty[i] >= 10) // Check for bulk discount
                {
                    dblLineDiscounts[i] = .05 * dblGross[i]; // Apply 5% discount
                }
                else
                {
                    dblLineDiscounts[i] = 0.00; // No discount
                }
            }

            
            for (int i = 0; i < intItemCount; i++) // Loop through items
            {
                intPostSaleStock[i] = intStocks[i] - intQty[i]; // Calculate remaining stock

                if (intPostSaleStock[i] < 5) // Check if reorder is needed
                {
                    boolReorder[i] = true; // Mark for reorder
                }
                else
                {
                    boolReorder[i] = false; // No reorder needed
                }
            }

            
            for (int i = 0; i < intItemCount; i++) // Loop through items
            {
                dblLineTotals[i] = dblGross[i] - dblLineDiscounts[i]; // Subtract discount from gross
            }

            Console.WriteLine("=== Order Summary ==="); // Print summary header
            Console.WriteLine($"{"Name",-15}{"Price",-10}{"Qty",-6}{"Gross",-10}" +
                $"{"Disc",-10}{"Line Total",-12}{"Reorder",-10}"); // Print column headers
            Console.WriteLine("-------------------------------------------------------------------------"); // Divider

            
            for (int i = 0; i < intItemCount; i++) // Loop through items
            {
                Console.WriteLine($"{strNames[i],-15}{dblPrices[i],-10:C}{intQty[i],-6}{dblGross[i],-10:C}{dblLineDiscounts[i],-10:C}" +
                    $"{dblLineTotals[i],-12:C}{(boolReorder[i] ? "Yes" : "No"),-10}"); // Print item details
            }

            Console.WriteLine("-------------------------------------------------------------------------"); // Divider

            double orderTotal = 0.00; // Initialize order total

            for (int i = 0; i < intItemCount; i++) // Loop through items
            {
                orderTotal += dblLineTotals[i]; // Add each line total to order total
            }

            double totalTax = orderTotal * .06; // Calculate 6% tax
            double entireTotal = orderTotal + totalTax; // Calculate grand total

            Console.WriteLine($"{"Subtotal:",-50}{orderTotal:C}"); // Print subtotal
            Console.WriteLine($"{"Tax (6%):",-50}{totalTax:C}"); // Print tax
            Console.WriteLine($"{"Grand Total:",-50}{entireTotal:C}"); // Print grand total

            Console.WriteLine("\nDone. Press Enter to exit."); // Final message before exit

        }
    }
}
