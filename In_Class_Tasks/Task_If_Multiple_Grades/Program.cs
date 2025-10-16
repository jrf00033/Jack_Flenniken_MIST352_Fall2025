/*
 * 9/16/2022
 * Ask user for multiple grades then evaluate and summarize
 */

namespace Task5___IF_multiple_grades_evaluation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many grades would you like to evaluate and summarize today?");
            //accept number of grades
            int intNoGrades = Convert.ToInt32(Console.ReadLine());
            int intAs = 0, intBs = 0, intCs = 0, intDs = 0, intFs = 0;
            
            //create and array to hold grades
            double[] dblGrades = new double[intNoGrades]; //new creates a new array allowing us to fill it with input
            char[] chrLetterGrades = new char[intNoGrades]; 

            //A for loop to interact with the array
            for (int intIndex = 0; intIndex <dblGrades.Length; intIndex++) //gets input for the number of grades
            {
                //Accept one grade and add it to the current element in the array
                Console.WriteLine($"Give me a grade{intIndex+1}:"); //int index changes every for loop
                dblGrades[intIndex] = Convert.ToDouble(Console.ReadLine());
            }

            for (int intIndex = 0; intIndex < dblGrades.Length; intIndex++) //gets input for the number of grades
            {
                if (dblGrades[intIndex] >= 90) //defining a letter grade for the user given grade inputs
                {
                    chrLetterGrades[intIndex] = 'A';
                    intAs++; //if evaluation is an A im adding 1 to the int intAs
                }
                else if (dblGrades[intIndex] >= 80)
                {
                    chrLetterGrades[intIndex] = 'B';
                    intBs++;
                }
                else if (dblGrades[intIndex] >= 70)
                {
                    chrLetterGrades[intIndex] = 'C';
                    intCs++;
                }
                else if (dblGrades[intIndex] >= 60)
                {
                    chrLetterGrades[intIndex] = 'D';
                    intDs++;
                }
                else
                {
                    chrLetterGrades[intIndex] = 'F';
                    intFs++;
                } 

            }
            //Printing out the number of each grade
            Console.WriteLine($"No of A\t\t{intAs}\nNo of B\t\t{intBs}\n" +
                $"No of C\t\t{intCs}\nNo of D\t\t{intDs}\nNo of F\t\t{intFs}\n" +
                //Number of passes and fails
                $"No of passes\t\t{intAs+intBs+intCs+intDs}\nNo of fails\t\t{intFs}");
        }
    }
} 
