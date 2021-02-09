using System;
using System.Collections.Generic;
using System.Text;

namespace Day11
{
    public class Animal
    {
        public Animal()
        {
            NumberOfLimbs = 0;
        }

        public int NumberOfLimbs { get; set; }

        public virtual string MakeSound()
        {
            return string.Empty;
        }
    }
}
