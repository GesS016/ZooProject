using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Options;

namespace Zoo.Animals
{
    public class TigerAnimal : AbstractAnimal
    {

        public TigerAnimal(string name, double age) : base(name, age)
        {
            Species = "Tiger";
            Biome = BiomType.Jungle;
            SquareToUnit = 20;
            MaxFoodForDay = 30;
            IsPredator = true;
            Food = new List<FoodType>()
            {
                FoodType.Fish,
                FoodType.Meat,
            };
            _sound = " RRR";
        }
    }
}
