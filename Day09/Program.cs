using System;

namespace Day09
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myVehicle = new Vehicle();
            var myOtherVehicle = new Vehicle("1234123413241324123");

            myVehicle.PrintLicensePlate();
            Console.WriteLine("-----------");
            myOtherVehicle.PrintLicensePlate();
            Console.WriteLine("-----------");
            myVehicle.PrintLicensePlate();
        }
    }
}
