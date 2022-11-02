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
            Food = new List<FoodType>()
            {
                FoodType.fish,
                FoodType.meat,
            };
            _sound = " RRR";
        }
        
        public override string Play()
        {
            string result = $"{Name} plays";
            return result;
        }
    }
}
