using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Tiger:AbstractAnimal
    {
        public Tiger(string name, string habitat, double unitsToSquare, double age, double weight, double maxWeight) : base(name, habitat, age, unitsToSquare, maxWeight, weight)
            {
            _sound = " RRR";
            }
        
        public override string Play()
        {
            string result = $"{Name} plays";
            return result;
        }
    }
}
