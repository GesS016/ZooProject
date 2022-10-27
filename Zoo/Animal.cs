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
        public double Weight { get; set; }
        public double MaxWeight { get; set; }
        public double UnitsToSquare { get; set; }
        public double Age { get;set; }
        public string[] Eat { get; set; }
        protected string _sound;
        public Animal(string name, string habitat, double unitsToSquare, double age, double weight, double maxWeight)
        {
            Name = name;
            Habitat = habitat;
            UnitsToSquare = unitsToSquare;
            Age = age;
            Weight = weight;
            MaxWeight = maxWeight;
        }

        public void Feed(string eat, double foodWeight)
        {
            if (Eat.Contains(eat))
            {
                Console.WriteLine($"{Name} ate {foodWeight} kg of {eat}");
            }
            if(Weight+foodWeight<MaxWeight)
            {
                Weight=+foodWeight;
                Console.WriteLine($"{Name} is {Weight} kg now");
            }
            else if(Weight + foodWeight>=MaxWeight)
            {
                Weight=MaxWeight;
                Console.WriteLine($"{Name} is {MaxWeight} kg now");
            }
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name}:{_sound}"); 
        }
    }
}
