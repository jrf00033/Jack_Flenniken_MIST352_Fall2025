/*
 * Practicing translating pseudocode
 * Jack Flennikne
 * 9/2/2025
 */


using System.Data;

namespace Practice3_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dblGrade1, dblGrade2, dblGrade3, dblGPA;
            String strName;
            Console.WriteLine("Hello, what is your name?");
            strName = Console.ReadLine();

            Console.WriteLine("Provide grade1");
            dblGrade1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Provide grade2");

            dblGrade2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Provide grade3");
            dblGrade3 = Convert.ToDouble(Console.ReadLine());

            dblGPA = (dblGrade1 + dblGrade2 + dblGrade3) / 3;

            Console.WriteLine($"Hello {strName}, the GPA of your grades {dblGrade1}, {dblGrade2},and {dblGrade3} is {dblGPA}");
            bool blnFail;
            blnFail = dblGPA <= 50;  //bool value will either be true or false
            //evaluate pass/fail
            Console.WriteLine($"Failed? {blnFail}");
        }
    }
}
