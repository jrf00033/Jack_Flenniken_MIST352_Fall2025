/*
 * Jack Flenniken
 * Tuesday 9/2/25
 * Practice translating Pseudocode to C#
 */

namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*double dblVal1, dblVal2;
            Console.WriteLine("Give me the first value: ");
            dblVal1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(dblVal1);
            //test
            Console.WriteLine("Give me the Second Value: ");
            dblVal2 = Convert.ToDouble(Console.ReadLine());

            double dblTotal = dblVal1 + dblVal2;
            Console.WriteLine($"The Sum of {dblVal1} and {dblVal2} is: {dblTotal}");*/


            //asking for inputs for integers specifically no decimals
            int dblVal1, dblVal2;
            Console.WriteLine("Give me the first value: ");
            dblVal1 = int.Parse(Console.ReadLine());
            //Console.WriteLine(dblVal1);
            //test
            Console.WriteLine("Give me the Second Value: ");
            dblVal2 = int.Parse(Console.ReadLine());

            int dblTotal = dblVal1 + dblVal2;
            Console.WriteLine($"The Sum of {dblVal1} and {dblVal2} is: {dblTotal}");
        }
    }
}
