using System;
using System.Collections.Generic;
using System.Text;

namespace Day10
{
    public class Car : Vehicle
    {
        // child classes must pass required parameters to the base class constructor
        public Car(string licensePlate, int year) : base(licensePlate, year)
        {

        }

        // Overriding a method from the base class.  We can only override if the base class method is 'virtual'
        public override string Print()
        {
            // The base class method can still be call from the sub class
            return base.Print() + "This car was made in " + Year;
        }
    }
}
