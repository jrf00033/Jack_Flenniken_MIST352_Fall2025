

namespace Practice5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //define an array of grades and assessments
            string[] strAssessments = {"Task1", "HW1", "Task2", "Quiz1", "Exam1", "HW2", "task3", "hw3" };
            float[] fltGrades = { 90, 88, 70, 95, 60, 50, 90, 55 };

            //for loop to access/read/manipulate contents of the array
            //starting at 0 and running the for loop for every string in the array
            for (int intIndex = 0; intIndex < strAssessments.Length; intIndex++)
            {
                Console.WriteLine($" Assessment {strAssessments[intIndex]}\t\t grade {fltGrades[intIndex]}");

            }

            Console.WriteLine("=============================================");
            Console.WriteLine("Printout homeworks only and their grades.");
            for (int intIndex = 0; intIndex < strAssessments.Length; intIndex++)//going through every string 
            {
                if (strAssessments[intIndex].Contains("HW") || strAssessments[intIndex].Contains("Task"))//asking the question, here im seeing of Assessments contain HW)
                {
                    Console.WriteLine($" Assessment {strAssessments[intIndex]}\t\t grade {fltGrades[intIndex]}"); //if above is true then run this command
                } }


            Console.WriteLine("=============================================");
            Console.WriteLine("Printout homeworks only and their grades (regardless upper or lower).");
            for (int intIndex = 0; intIndex < strAssessments.Length; intIndex++)//going through every string 
                {
                    if (strAssessments[intIndex].ToLower().Contains("hw") || strAssessments[intIndex].ToLower().Contains("task")/*asking the question, here im seeing of Assessments contain HW*/)
                    {
                        Console.WriteLine($" Assessment {strAssessments[intIndex]}\t\t grade {fltGrades[intIndex]}"); //if above is true then run this command
                    }


                }

            Console.WriteLine("=============================================");
            Console.WriteLine("Printout homeworks only and their grades (regardless upper or lower).");
            for (int intIndex = 0; intIndex < strAssessments.Length; intIndex++)//going through every string 
            {
                if (strAssessments[intIndex].ToLower().Contains("hw") || strAssessments[intIndex].ToLower().Contains("task")/*asking the question, here im seeing of Assessments contain HW*/)
                {
                    Console.WriteLine($" Assessment {strAssessments[intIndex]}\t\t grade {fltGrades[intIndex]}"); //if above is true then run this command
                }


            }


        }
    }
}
