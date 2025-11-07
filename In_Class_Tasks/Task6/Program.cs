/*
 * Name: Jack Flenniken
 * Date: 11.4.2025
 * Purpose: Create 3 classes m
 */

namespace Task6
{
    internal class Program
    {      
        static void Main(string[] args)
        {
            Car Car1 = new Car(); 
            //creating a new car
            Employee Employee1 = new Employee();
            //creating a new employee
            Account Account1 = new Account();
            //creating a new account

            Car1.DisplayInfo();
            //Displaying info for the Car class
            Employee1.DisplaySummary();
            //Displaying info for the Employee class
            Account1.DisplayInfo();
            //Displaying info for the account class
        }
    }
}
