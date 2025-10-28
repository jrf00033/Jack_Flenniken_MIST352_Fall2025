namespace Practice8_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student mj = new Student("800-0000","MJ", "Ahmad"); //mj is an object of type student, student is the class
            //because of my constrcutor method I need to add the above info to create a student
            //creating new students using the class
            mj.FirstName = "Mohammed"; //defining data in the class
            mj.SetGPA(3.1);
            mj.phone = "555-555-5555";
            mj.LastName = "Ahmad";
            mj.SetID("800-1111"); //using the method it sets the ID
            mj.PrintInfo();


            Student sarah = new Student("900-0000", "Sarah","Green"); //definining a new student
            sarah.SetID("900-0000"); //adding data
            sarah.FirstName = "Sarah";
            sarah.LastName = "Green";
            sarah.SetGPA(4.0);
            sarah.phone = "555-222-2222";
            sarah.PrintInfo();

            if (mj.GetGPA() < sarah.GetGPA())
            {
                Console.WriteLine("Sarah is smarter than MJ");
            }
            else
                Console.WriteLine("MJ is smarter than Sarah");
            
            
        }
            
        
    }
}
