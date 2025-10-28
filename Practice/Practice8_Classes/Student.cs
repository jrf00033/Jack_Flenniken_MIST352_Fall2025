using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
//creating a new class
{
    private string ID; //defining data that is in the class but not the values
    private double dblGpa; // by making it private classes cannot access this, so there is logic that only applies to thise double
    public string FirstName;
    public string LastName;
    public string phone;

    public void SetID(string theID)
    //this method is called a setter because it sets the value of the ID to whatever you want
    {
        ID = theID;
    }

    public void SetGPA(double theGPA)
    {
        while (theGPA < 0 || theGPA > 4) // limiting what the GPA can be
        //while is made so that we can keep asking until we get a valid gpa.
        {
            Console.WriteLine($"The {theGPA} is invalid. It has to be between 0 and 4. Insert again.");
            theGPA = double.Parse(Console.ReadLine());
        }
        //after the GPA meets this condition the while loop stops and sets the GPA
        dblGpa = theGPA;
        
    }
    //creating a method requiring that a student has a defined ID and name
    public Student(String anID, string FName, string LName)
    //when you create a method that has the same name as a class it becomes a constructor
    {
        //in order to create a student they must give 3 pieces of info
        ID = anID;
        FirstName = FName;
        LastName = LName;
    }

    public Student(String anID)
    //overloaded constructor
    {
        ID = anID;
        FirstName = "";
        LastName = "";
    }

    public double GetGPA() //this is a get method, were retrieving a value
    {
        return dblGpa; 
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{FirstName} {LastName} with ID: {ID} has GPA {dblGpa} and phone: {phone}");
    }
}
