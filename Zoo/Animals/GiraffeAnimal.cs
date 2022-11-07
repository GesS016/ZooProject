using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Options;

namespace Zoo.Animals
{
    public class GiraffeAnimal : AbstractAnimal
    {
        public GiraffeAnimal(string name, double age) : base(name, age)
        {
            Species = "Giraffe";
            Biome = BiomType.Savannah;
            SquareToUnit = 30;
            MaxFoodForDay = 30;
            IsPredator = false;
            Food = new List<FoodType>()
            {
                FoodType.Leaves,
                FoodType.Hay,
            };
            _sound = " UIII";
        }
    }
}
