using System;
using System.Collections.Generic;
using System.Text;

namespace Day17
{
    public class TemperatureConverter
    {
        public int Convert(int temp, string type)
        {
            switch (type.ToLower())
            {
                case "c":
                    return (temp - 32) * 5 / 9;
                case "f":
                    return (temp * 9 / 5) + 32;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type));
            }
        }
    }
}
