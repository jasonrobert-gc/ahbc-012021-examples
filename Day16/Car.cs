using System;
using System.Collections.Generic;
using System.Text;

namespace Day16
{
    public class Car
    {
        public string Make { get; }
        public string Model { get; }

        public Car(string make, string model)
        {
            Make = make;
            Model = model;
        }
    }
}
