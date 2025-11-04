using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Employee
    {
        private string _name;
        private double _hourlyRate;
        private int _hoursPerWeek;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double HourlyRate
        {
            get { return _hourlyRate; }
            set { _hourlyRate = value; }
        }

        public int HoursPerWeek
        {
            get { return _hoursPerWeek; }
            set { _hoursPerWeek = value; }
        }
        
        public Employee()
        {
            this._name = "New Hire";
            this._hourlyRate = HourlyRate;
            this._hoursPerWeek = HoursPerWeek;
            
        }

        
    }

}
