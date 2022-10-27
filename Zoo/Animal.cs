using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Habitat { get;  protected set; }
        public double UnitsToSquare { get; set; }
        public double Age { get;set; }
        public string[] Eat { get; set; }
        protected string _sound;
        public Animal(string name, string habitat, double unitsToSquare, double age)
        {
            Name = name;
            Habitat = habitat;
            UnitsToSquare = unitsToSquare;
            Age = age;
        }
        public void Feed(string eat, double foodWeight)
        {
            if (Eat.Contains(eat))
            {
                Console.WriteLine($"{Name} ate {foodWeight} kg of Food")
            }
        }
    }
}
