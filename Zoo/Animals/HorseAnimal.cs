using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Options;

namespace Zoo.Animals
{
    public class HorseAnimal : AbstractAnimal
    {
        public HorseAnimal(string name, double age) : base(name, age)
        {
            Species = "Horse";
            Biome = BiomType.Prairie; //прерия
            SquareToUnit = 10;
            MaxFoodForDay = 20;
            IsPredator = false;
            Food = new List<FoodType>()
            {
                FoodType.Hay,
            };
            _sound = " OHOHO";
        }
    }
}
