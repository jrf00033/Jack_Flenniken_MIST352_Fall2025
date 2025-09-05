/*
 * Author: Jack Flenniken
 * Class: MIST352-Fall2025
 * HW #1
 * This program receives info about products and orders them into a neat total while calculating total price
 */


using System;

namespace HW1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //Printing text to prompt input
            Console.WriteLine("Enter Information for product 1"); 
            //Printing Prompt for Product Name
            Console.WriteLine("Product Name:");
            //Collecting input for Product Name
            String strProdName1 = Console.ReadLine().Trim();
            //Selecting and capitalizing first letter of input
            String strProdCap1 = strProdName1.Substring(0, 1).ToUpper();
            //Selecting and lower casing rest of input
            String strProdLow1 = strProdName1.Substring(1).ToLower();
            //Connecting the capital letter and rest of word
            String strProdNameF1 = String.Concat(strProdCap1, strProdLow1);
 
            //Printing Prompt for Serial Number
            Console.WriteLine("Product Serial Number:");
            //Collecting input for serial number
            int intSerialNum1 = int.Parse(Console.ReadLine().Trim());

            //Printing Prompt for Product Price
            Console.WriteLine("Product Price:");
            //Collecting input for Product Price
            double dblPrice1 = Convert.ToDouble(Console.ReadLine().Trim());

            //Printing Prompt for Product Quantity
            Console.WriteLine("Product Quantity:");
            //Collecting input for Product Quantity
            double dblProdQuantity1 = Convert.ToDouble(Console.ReadLine().Trim());

            //Printing Prompt for Product Category
            Console.WriteLine("Product Category:");
            //Collecting input for product category
            String strCatName1 = Console.ReadLine().Trim();
            //Selecting and capitalizing first letter of input
            String strCatCap1 = strCatName1.Substring(0, 1).ToUpper();
            //selecting and lower casing rest of input
            String strCatLow1 = strCatName1.Substring(1).ToLower();
            //Connecting capital letter and rest of word
            String strCatNameF1 = String.Concat(strCatCap1, strCatLow1);
                        
            //PRODUCT 2

            //Printing text to prompt input
            Console.WriteLine("Enter Information for product 2");
            //Printing Prompt for Product Name
            Console.WriteLine("Product Name:");
            //Collecting input for Product Name
            String strProdName2 = Console.ReadLine().Trim();
            //Selecting and capitalizing first letter of input
            String strProdCap2 = strProdName2.Substring(0, 1).ToUpper();
            //Selecting and lower casing rest of input
            String strProdLow2 = strProdName2.Substring(1).ToLower();
            //Connecting the capital letter and rest of word
            String strProdNameF2 = String.Concat(strProdCap2, strProdLow2);

            //Printing Prompt for Serial Number
            Console.WriteLine("Product Serial Number:");
            //Collecting input for serial number
            int intSerialNum2 = int.Parse(Console.ReadLine().Trim());

            //Printing Prompt for Product Price
            Console.WriteLine("Product Price:");
            //Collecting input for Product Price
            double dblPrice2 = Convert.ToDouble(Console.ReadLine().Trim());

            //Printing Prompt for Product Quantity
            Console.WriteLine("Product Quantity:");
            //Collecting input for Product Quantity
            double dblProdQuantity2 = Convert.ToDouble(Console.ReadLine().Trim());

            //Printing Prompt for Product Category
            Console.WriteLine("Product Category:");
            //Collecting input for product category
            String strCatName2 = Console.ReadLine().Trim();
            //Selecting and capitalizing first letter of input
            String strCatCap2 = strCatName2.Substring(0, 1).ToUpper();
            //selecting and lower casing rest of input
            String strCatLow2 = strCatName2.Substring(1).ToLower();
            //Connecting capital letter and rest of word
            String strCatNameF2 = String.Concat(strCatCap2, strCatLow2);

            //Calculating total price for this product
            String totalPrice2 = "$" + dblPrice2 * dblProdQuantity2;

            //PRODUCT 3

            //Printing text to prompt input
            Console.WriteLine("Enter Information for product 3");
            //Printing Prompt for Product Name
            Console.WriteLine("Product Name:");
            //Collecting input for Product Name
            String strProdName3 = Console.ReadLine().Trim();
            //Selecting and capitalizing first letter of input
            String strProdCap3 = strProdName3.Substring(0, 1).ToUpper();
            //Selecting and lower casing rest of input
            String strProdLow3 = strProdName3.Substring(1).ToLower();
            //Connecting the capital letter and rest of word
            String strProdNameF3 = String.Concat(strProdCap3, strProdLow3);

            //Printing Prompt for Serial Number
            Console.WriteLine("Product Serial Number:");
            //Collecting input for serial number
            int intSerialNum3 = int.Parse(Console.ReadLine().Trim());

            //Printing Prompt for Product Price
            Console.WriteLine("Product Price:");
            //Collecting input for Product Price
            double dblPrice3 = Convert.ToDouble(Console.ReadLine().Trim());

            //Printing Prompt for Product Quantity
            Console.WriteLine("Product Quantity:");
            //Collecting input for Product Quantity
            double dblProdQuantity3 = Convert.ToDouble(Console.ReadLine().Trim());

            //Printing Prompt for Product Category
            Console.WriteLine("Product Category:");
            //Collecting input for product category
            String strCatName3 = Console.ReadLine().Trim();
            //Selecting and capitalizing first letter of input
            String strCatCap3 = strCatName3.Substring(0, 1).ToUpper();
            //selecting and lower casing rest of input
            String strCatLow3 = strCatName3.Substring(1).ToLower();
            //Connecting capital letter and rest of word
            String strCatNameF3 = String.Concat(strCatCap3, strCatLow3);

            //PRODUCT 4

            //Printing text to prompt input
            Console.WriteLine("Enter Information for product 4");
            //Printing Prompt for Product Name
            Console.WriteLine("Product Name:");
            //Collecting input for Product Name
            String strProdName4 = Console.ReadLine().Trim();
            //Selecting and capitalizing first letter of input
            String strProdCap4 = strProdName4.Substring(0, 1).ToUpper();
            //Selecting and lower casing rest of input
            String strProdLow4 = strProdName4.Substring(1).ToLower();
            //Connecting the capital letter and rest of word
            String strProdNameF4 = String.Concat(strProdCap4, strProdLow4);

            //Printing Prompt for Serial Number
            Console.WriteLine("Product Serial Number:");
            //Collecting input for serial number
            int intSerialNum4 = int.Parse(Console.ReadLine().Trim());

            //Printing Prompt for Product Price
            Console.WriteLine("Product Price:");
            //Collecting input for Product Price
            double dblPrice4 = Convert.ToDouble(Console.ReadLine().Trim());

            //Printing Prompt for Product Quantity
            Console.WriteLine("Product Quantity:");
            //Collecting input for Product Quantity
            double dblProdQuantity4 = Convert.ToDouble(Console.ReadLine().Trim());

            //Printing Prompt for Product Category
            Console.WriteLine("Product Category:");
            //Collecting input for product category
            String strCatName4 = Console.ReadLine().Trim();
            //Selecting and capitalizing first letter of input
            String strCatCap4 = strCatName4.Substring(0, 1).ToUpper();
            //selecting and lower casing rest of input
            String strCatLow4 = strCatName4.Substring(1).ToLower();
            //Connecting capital letter and rest of word
            String strCatNameF4 = String.Concat(strCatCap4, strCatLow4);

            //Table
           
            //Printing Top line for the table
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            //Printing Table Column Names and defining width parameters
            Console.WriteLine($" {"Name",-15}|| {"Serial",-12}|| {"Price",-10}|| {"Quantity",-10}|| {"Category",-15}|| {"Total Price",-12}");
            //Printing seperating line for the table
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            //Printing product 1 values and defining width parameters
            Console.WriteLine($" {strProdNameF1,-15}|| {intSerialNum1,-12}|| {dblPrice1,-10:C}|| {dblProdQuantity1,-10}|| {strCatNameF1,-15}|| {(dblPrice1 * dblProdQuantity1),-12:C}");
            //Printing product 2 values and defining width parameters
            Console.WriteLine($" {strProdNameF2,-15}|| {intSerialNum2,-12}|| {dblPrice2,-10:C}|| {dblProdQuantity2,-10}|| {strCatNameF2,-15}|| {(dblPrice2 * dblProdQuantity2),-12:C}");
            //Printing product 3 values and defining width parameters
            Console.WriteLine($" {strProdNameF3,-15}|| {intSerialNum3,-12}|| {dblPrice3,-10:C}|| {dblProdQuantity3,-10}|| {strCatNameF3,-15}|| {(dblPrice3 * dblProdQuantity3),-12:C}");
            //Printing product 4 values and defining width parameters
            Console.WriteLine($" {strProdNameF4,-15}|| {intSerialNum4,-12}|| {dblPrice4,-10:C}|| {dblProdQuantity4,-10}|| {strCatNameF4,-15}|| {(dblPrice4 * dblProdQuantity4),-12:C}");

        }
    }
}
