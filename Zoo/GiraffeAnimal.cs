using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class GiraffeAnimal:AbstractAnimal
    {
        public GiraffeAnimal(string name, double age):base(name,age)
        {
            Species = "Giraffe";
            Biome = "savannah"; 
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
