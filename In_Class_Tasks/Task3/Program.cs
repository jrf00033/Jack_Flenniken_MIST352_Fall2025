/*
 * Author: Jack
 * Date: 9/9/2025
 */

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating doubles and giving them values
            double dblGrade1 = 50, dblGrade2 = 90, dblGrade3 = 63, dblGrade4 = 80, dblGrade5 = 70, dblAvg = 0, dblSum = 0;
            dblAvg = (dblGrade1 + dblGrade2 + dblGrade3 + dblGrade4 + dblGrade5) / 5;
            Console.WriteLine($"Hello Jack FLenniken, your average is {dblAvg}");

            //define an array that can only hold doubles and then define how many doubels it has (5)
            double[] dblGrades = new double[5];
            //Index starts at 0 (0,1,2...)
            dblGrades[0] = 50;
            dblGrades[1] = 90;
            dblGrades[2] = 63;
            dblGrades[3] = 80;
            dblGrades[4] = 70;

            //More efficient way to make an array and define it, but you cant set a certain amount of values
            double[] dblGradesFancy = { 50, 90, 63, 80, 70, 90, 99 };
            String[] strAssessments = { "Task1","HW1","Task2","Quiz1","Exam1", "HW2", "Quiz2" };
            //Printing the values from dblGradesFancy
            //Console.WriteLine($"{dblGradesFancy[0]} - {dblGradesFancy[1]} - {dblGradesFancy[2]} - {dblGradesFancy[3]} - {dblGradesFancy[4]}");
            //calculate average (manually)
            //dblAvg = (dblGradesFancy[0] + dblGradesFancy[1] + dblGradesFancy[2] + dblGradesFancy[3] + dblGradesFancy[4]) / 5;
            //Console.WriteLine($"Hello Jack Flenniken, your average is {dblAvg}");

            //for loop to interact with arrays
            //define an index = 0 and then asks is the index is less than 5, if so it goes to the for loop immediately, then adds 1 index until it doesnt meet the requirement
            //for (int intIndex = 0; intIndex < 5; intIndex++)
            for (int intIndex = 0; intIndex < dblGradesFancy.Length; intIndex++) //by setting to .length the index will always be less than length and the length changes itself
            //scope of the for loop
            {
                //Console.WriteLine(strAssessments[intIndex]); //prints the value at (0,1,2,3,4) for this then
                //Console.Writeline(dblGradesFancy[intIndex]); //prints the value at (0,1,2,3,4) then repeats

                //Console.WriteLine($"{strAssessments[intIndex]} - {dblGradesFancy[intIndex]}"); //prints out values at matching index with that formatting
                //dblSum = dblSum + dblGradesFancy[intIndex]; //dblSum + grade it is reading
                dblSum += dblGradesFancy[intIndex]; //better version of line above
                
            }
                Console.WriteLine($"The average is {dblSum / dblGradesFancy.Length}"); //calculating average
        }
    }
}
