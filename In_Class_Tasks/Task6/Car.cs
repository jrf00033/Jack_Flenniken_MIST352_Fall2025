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
        private string _make;
        //adding a string value for make
        private string _model;
        //adding a string value for model
        private int _year;
        //adding a int value for year

        public string Make 
        //making name available from outside the class
        {
            get { return _make; }
            set
            {
                _make = value;
            }
        }

        public string Model 
        //making model available from outside the class
        {
            get { return _model; }
            set
            {
                _model = value;
            }
        }

        public int Year 
        //making year available from outside the class
        {
            get { return _year; }
            set
            {
                _year = value;
            }
        }
    
   
        public Car()
         {
            this._make = "N/A";
            this._model = "N/A";
            this._year = 0000;
         }

        public Car(string make, string model)
        {
            this._make = make;
            this._model = model;
            this._year = DateTime.Now.Year;
        }

        public Car(string make, string model, int year)
        {
            if (year < 1900 || year > DateTime.Now.Year)
            {
                throw new ArgumentException("Year must be provided");
            }

            this._make = make;
            this._model = model;
            this._year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Make: {_make}, Model: {_model}, Year: {_year}");
        }
        




    } 
}
