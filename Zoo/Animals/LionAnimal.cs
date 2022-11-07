using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Options;

namespace Zoo.Animals
{
    public class LionAnimal : AbstractAnimal
    {
        public LionAnimal(string name, double age) : base(name, age)
        {
            Species = "Lion";
            Biome = BiomType.Savannah;
            SquareToUnit = 20;
            MaxFoodForDay = 30;
            IsPredator = true;
            Food = new List<FoodType>()
            {
                FoodType.Fish,
                FoodType.Meat,
            };
            _sound = " RROAR";
        }
    }
}
