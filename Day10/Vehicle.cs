using System;
using System.Collections.Generic;
using System.Text;

namespace Day10
{
    public class Vehicle
    {
        public Vehicle(string licensePlate, int year)
        {
            LicensePlate = licensePlate;
            Year = year;
        }

        public string LicensePlate { get; }
        protected int Year { get; }

        // The virutal keyword allows a base class to override it
        public virtual string Print()
        {
            return "This vehicle was made in " + Year;
        }
    }
}
