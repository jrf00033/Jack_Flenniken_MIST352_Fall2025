using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Car //creating class car
    {
        private string _make; // declaring a private string field to store the car's make
        private string _model; // declaring a private string field to store the car's model
        private int _year; // declaring a private integer field to store the car's year

        public string Make // public property to access and modify the car's make
        {
            get { return _make; } // getter returns the value of _make
            set // setter assigns a value to _make
            {
                _make = value; // assigning the input value to the _make field
            }
        }

        public string Model // public property to access and modify the car's model
        {
            get { return _model; } // getter returns the value of _model
            set // setter assigns a value to _model
            {
                _model = value; // assigning the input value to the _model field
            }
        }

        public int Year // public property to access and modify the car's year
        {
            get { return _year; } // getter returns the value of _year
            set // setter assigns a value to _year
            {
                _year = value; // assigning the input value to the _year field
            }
        }

        public Car() // default constructor initializes fields with default values
        {
            this._make = "N/A"; // setting default make to "N/A"
            this._model = "N/A"; // setting default model to "N/A"
            this._year = 0000; // setting default year to 0000
        }

        public Car(string make, string model) // constructor with make and model parameters
        {
            this._make = make; // assigning the make parameter to _make
            this._model = model; // assigning the model parameter to _model
            this._year = DateTime.Now.Year; // setting year to the current year
        }

        public Car(string make, string model, int year) // constructor with make, model, and year parameters
        {
            if (year < 1900 || year > DateTime.Now.Year) // validating that year is within a reasonable range
            {
                throw new ArgumentException("Year must be provided"); // throwing an exception if year is invalid
            }

            this._make = make; // assigning the make parameter to _make
            this._model = model; // assigning the model parameter to _model
            this._year = year; // assigning the year parameter to _year
        }

        public void DisplayInfo() // method to display car information
        {
            Console.WriteLine($"Make: {_make}, Model: {_model}, Year: {_year}"); // printing car details to the console
        }





    } 
}
