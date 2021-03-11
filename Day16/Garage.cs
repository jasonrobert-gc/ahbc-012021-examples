using System;
using System.Collections.Generic;

namespace Day16
{
    public class Garage
    {
        public List<Car> Cars { get; set; }
        public int Capacity { get; set; }

        public Garage()
        {
            Capacity = 3;
            Cars = new List<Car>();

            var car1 = new Car("Ram", "1500");
            Cars.Add(car1);

            var car2 = new Car("Chevy", "Tahoe");
            Cars.Add(car2);

            Cars.Add(new Car("Ford", "Mustang"));
        }

        public bool DoTheyFit()
        {
            // return Capacity >= Cars.Count;
            if (Capacity >= Cars.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
