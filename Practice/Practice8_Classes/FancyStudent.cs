using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8_Classes
{
    public class FancyStudent
    {
        // Fields (private variables)
        private string _name;
        private int _age;
        private double _gpa;

        // Property (encapsulated access)
        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _name = value;
                else
                    throw new ArgumentException("Name cannot be empty.");
            }
        }
        // Constructor (used to initialize the object)
        public FancyStudent(string name, int age, double gpa)
        {
            this._name = name;
            this._age = age;
            this._gpa = gpa;
        }

        // Constructor (used to initialize the object)
        public FancyStudent(string name)
        {
            this._name = name;
            this._age=0;
            this._gpa = 0;
        }

        // Constructor (used to initialize the object)
        public FancyStudent(int age)
        {
            this._name = "Not Provided";
            this._age = age;
            this._gpa = 0;
        }

        // Method (behavior of the class)
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {_name}, Age: {_age}, GPA: {_gpa}");
        }

        // Method that returns a value
        public bool IsHonorStudent()
        {
            return _gpa >= 3.5;
        }
    }
}

