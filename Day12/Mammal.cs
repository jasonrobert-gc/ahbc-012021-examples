using System;
using System.Collections.Generic;
using System.Text;

namespace Day12
{
    public class Mammal : Animal
    {
        public sealed override bool HasFur()
        {
            return true;
        }

        public override string MakeSound()
        {
            return "Some mammal sound";
        }
    }
}
