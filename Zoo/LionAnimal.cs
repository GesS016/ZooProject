using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class LionAnimal:AbstractAnimal
    {
        public LionAnimal(string name, double age):base(name,age)
        {
            Species = "Lion";
            Biome = "savannah";
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
