using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class TigerAnimal:AbstractAnimal
    {
        
        public TigerAnimal(string name, string biome, double unitsToSquare, double age, double maxFoodForDay) : base(name, biome, age, unitsToSquare, maxFoodForDay)
        {
            FoodType = new List<string>()
            {
                "meat",
                "fish",
            };
            _sound = " RRR";
        }
        
        public override string Play()
        {
            string result = $"{Name} plays";
            return result;
        }
        public override string Feed(string eat, double foodWeight)
        {
            if (tigerFoodType.Contains(eat))
            {
                return base.Feed(eat, foodWeight);
            }
            else
            {
                return $"{Name} doesn't eat {eat}";
            }
        }
    }
}
