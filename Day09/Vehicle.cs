using System;

namespace Day09
{
    // Pascal case and should be singular
    public class Vehicle
    {
        //// Instance Variable, class field, instance field, class variable  -- Never should be public
        // public string LicensePlate; 

        //// This is where properties come in
        //private string _licensePlate;
        //public string LicensePlate
        //{
        //    get
        //    {
        //        return _licensePlate;
        //    }
        //    set
        //    {
        //        _licensePlate = value;
        //    }
        //}

        // Constructor - This is a good place to initialize things
        // Constructors can take parameters
        public Vehicle()
        {
            LicensePlate = string.Empty;
        }

        // Constructors can be overloaded!
        public Vehicle(string licensePlate) // parameters are camel case
        {
            LicensePlate = licensePlate;
        }

        // private "instance" variable / field
        // Start with an underscore and camel case
        private int _count;

        // public property
        // Pascal case
        public string LicensePlate { get; set; }

        // public class method
        // Pascal case
        public void PrintLicensePlate()
        {
            var methodVariable = "Hello world"; // method variables - camel case
            _count++;
            Console.WriteLine($"The license plate is {LicensePlate}");
            Console.WriteLine($"You asked me {_count} time(s)");
        }
    }
}
