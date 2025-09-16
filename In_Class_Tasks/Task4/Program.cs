/*
 * 9/16/25
 * Simple program to evaluate and printout the letter grade of a given grade
 */

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a grade");
            double dblGrade = Double.Parse(Console.ReadLine());//converting double to string

            if (dblGrade > 100 || dblGrade < 0) { //setting parameters for input

                Console.WriteLine("Invalid input. Should be between 0 and 100. Rerun again");
                return; //ends the program without going through the rest of the code

                    }

            if (dblGrade >= 90) //if grade is 90 or higher return A
            {
                Console.WriteLine("A");
            }

            else if (dblGrade >=80)
            {
                Console.WriteLine("B");
            }

            else if (dblGrade >=70)
            {
                Console.WriteLine("C");
            }

            else if(dblGrade >=60)
            {
                Console.WriteLine("D");
            }

            else //if anything lower than 60 then its an F
            {
                Console.WriteLine("F");
            }
        }
    }
}
