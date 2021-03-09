using System;
using System.Collections.Generic;
using System.Text;

namespace MockAssessment3
{
    public class Town
    {
        public List<Villager> Villagers { get; set; }

        public Town()
        {
            Villagers = new List<Villager>();
            Villagers.Add(new Farmer());
            Villagers.Add(new Slacker());
            Villagers.Add(new Slacker());
            Villagers.Add(new Slacker());
        }

        public int Harvest()
        {
            var result = 0;
            foreach (var villager in Villagers)
            {
                result += villager.Farm();
            }

            return result;
        }

        public int CalcFoodConsumption()
        {
            var result = 0;
            foreach (var villager in Villagers)
            {
                result += villager.Hunger;
            }

            return result;
        }

        public bool SurviveTheWinter()
        {
            // return CalcFoodConsumption() <= Harvest();

            if (CalcFoodConsumption() <= Harvest())
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
