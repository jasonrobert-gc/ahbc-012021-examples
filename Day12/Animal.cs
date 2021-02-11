using System;
using System.Collections.Generic;
using System.Text;

namespace Day12
{
    public abstract class Animal
    {
        public int NumberOfLimbs { get; set; }

        public virtual bool HasFur()
        {
            return false;
        }

        public abstract string MakeSound();
    }
}
