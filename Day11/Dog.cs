using System;
using System.Collections.Generic;
using System.Text;

namespace Day11
{
    public class Dog : Mammal
    {
        public Dog()
        {
            NumberOfLimbs = 4;
        }

        public DogEarType EarType { get; set; }

        public void BiteAStranger()
        {
            Console.Write("CHOMP ");
        }

        public sealed override string MakeSound()
        {
            return "Ruff ruff ruff";
        }
    }
}
