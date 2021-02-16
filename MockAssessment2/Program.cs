using System;
using System.Collections.Generic;

namespace MockAssessment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"AddStarWarsCharacters - {AddStarWarsCharacters(new[] { "Luke", "Han", "Yoda" })}");

            var players = new Dictionary<string, int>
            {
                { "Luke", 99999 },
                { "Han", 90000 },
                { "Kylo Ren", 95000 }
            };
            Console.WriteLine($"DeathStarCombat - {DeathStarCombat(players)}");
            var planets = ConvertPlanets(new[] { "Naboo", "Tatooine", "Hoth"});

            Console.WriteLine($"AverageDroids - {AverageDroids(new List<int>{ 1, 1, 1, 2, 4 })}");
            Console.WriteLine($"TryToCatchDarthVader - {TryToCatchDarthVader("a")}");
        }

        private static int AddStarWarsCharacters(string[] names)
        {
            // return Array.IndexOf(names, "Yoda");
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == "Yoda")
                {
                    return i;
                }
            }

            return -1;
        }

        private static string DeathStarCombat(Dictionary<string, int> characters)
        {
            string name = null;
            var attack = int.MinValue;
            foreach (var character in characters)
            {
                if (character.Value > attack)
                {
                    attack = character.Value;
                    name = character.Key;
                }
            }

            return name;
        }

        private static List<string> ConvertPlanets(string[] planets)
        {
            //var result = new List<string>(planets);
            //result.Reverse();
            //return result;

            var result = new List<string>();
            for (int i = planets.Length - 1; i >= 0; i--)
            {
                result.Add(planets[i]);
            }

            return result;
        }

        private static int AverageDroids(List<int> droids)
        {
            //var count = 0;
            //var sum = 0;
            //foreach (var droid in droids)
            //{
            //    if (droid % 2 == 0)
            //    {
            //        sum += droid;
            //        count++;
            //    }
            //}

            //return sum / count;

            // Using the hint
            var evens = new List<int>();
            foreach (var droid in droids)
            {
                if (droid % 2 == 0)
                {
                    evens.Add(droid);
                }
            }

            var sum = 0;
            foreach (var even in evens)
            {
                sum += even;
            }

            return sum / evens.Count;
        }

        private static string TryToCatchDarthVader(string input)
        {
            try
            {
                int.Parse(input);
                return "Vader was captured";
            }
            catch (FormatException)
            {
                return "Vader got away";
            }
        }
    }
}
