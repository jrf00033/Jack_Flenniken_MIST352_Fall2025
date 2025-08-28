/*
 * Author: Jack Flenniken
 * Practice 1
 * Date: Thursday 8/28/25
 * Purpose: Functionality 1 => defined variables and process them to calculate areas of circles
 */

namespace Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("======= THis if Functionality 1=======");
            //A VARIABLE SHOULD REFLECT ITS CONTENT!!
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("The area of the circle with radius 1 is 3.14");
            double theRadius = 15.5; //variable to hold the radius, dont name a variable with a letter
            double theArea = (theRadius * theRadius * 3.14); //variable to hold the area double allows decimals
            //below code prints out the info in different ways
            Console.WriteLine("The circle with a radius of " + theRadius + " is " + theArea);
            Console.WriteLine("The circle with a radius of {0} is {1}", theRadius , theArea); //insert variable into 0 and 1
            Console.WriteLine($"The circle with a radius of {theRadius} is {theArea}"); //user dollar sign so that the variables arent taken as text

            Console.WriteLine("======================================");
        }
    }
}
