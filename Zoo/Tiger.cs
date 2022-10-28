using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Tiger:AbstractAnimal
    {
        public Tiger(string name, string habitat, double unitsToSquare, double age, double weight, double maxWeight) : base(name, habitat, age, unitsToSquare, maxWeight, weight)
            {
            }
        public override void Play()
        {
            Console.WriteLine($"{Name} plays");
        }
    }
}
