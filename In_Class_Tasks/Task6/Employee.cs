using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Employee
    {
        private string _name; // declaring a private string field to store the employee's name
        private double _hourlyRate; // declaring a private double field to store the employee's hourly rate
        private int _hoursPerWeek; // declaring a private integer field to store the employee's weekly working hours

        public string Name // public property to access and modify the employee's name
        {
            get { return _name; } // getter returns the value of _name
            set { _name = value; } // setter assigns a value to _name
        }

        public double HourlyRate // public property to access and modify the employee's hourly rate
        {
            get { return _hourlyRate; } // getter returns the value of _hourlyRate
            set { _hourlyRate = value; } // setter assigns a value to _hourlyRate
        }

        public int HoursPerWeek // public property to access and modify the employee's weekly hours
        {
            get { return _hoursPerWeek; } // getter returns the value of _hoursPerWeek
            set { _hoursPerWeek = value; } // setter assigns a value to _hoursPerWeek
        }

        public Employee() // default constructor initializes fields with default or existing property values
        {
            this._name = "New Hire"; // setting default name to "New Hire"
            this._hourlyRate = HourlyRate; // assigning the current HourlyRate property value to _hourlyRate
            this._hoursPerWeek = HoursPerWeek; // assigning the current HoursPerWeek property value to _hoursPerWeek
        }

        public Employee(string Name) // constructor that takes name and assigns default HourlyRate
        {
            this._name = Name; // assigning the Name parameter to _name
            this._hourlyRate = HourlyRate; // assigning the current HourlyRate property value to _hourlyRate
        }

        public Employee(string Name, double Rate, int Hours) // constructor that takes name, rate, and hours
        {
            this._name = Name; // assigning the Name parameter to _name

            if (Rate > 0) // checking if the provided rate is positive
            {
                this._hourlyRate = Rate; // assigning the Rate parameter to _hourlyRate
            }
            else // if Rate is not positive
            {
                Console.WriteLine("Hourly rate must be entered."); // printing error message for invalid rate
            }

            if (Hours > 0) // checking if the provided hours are positive
            {
                this._hoursPerWeek = Hours; // assigning the Hours parameter to _hourlyRate (likely a bug: should be _hoursPerWeek)
            }
            else // if Hours is not positive
            {
                Console.WriteLine("Hours must be entered."); // printing error message for invalid hours
            }
        }

        public void DisplaySummary() // method to display employee summary
        {
            Console.WriteLine($"Employee Name: {Name}, Employee Salary:{(HoursPerWeek * HourlyRate) * 52}"); // printing name and annual salary
        }
    }
}
