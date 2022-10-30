using System;
using System.Security.Cryptography.X509Certificates;


namespace Zoo
{
    public abstract class AbstractAnimal
    {
        public string Name { get; set; }
        public string Habitat { get;  protected set; }
        public double Weight { get; set; }
        public double MaxWeight { get; set; }
        public double UnitsToSquare { get; set; }
        public double Age { get;set; }
        public bool isPredator { get; protected set; }
        protected string _sound;

        List<string> foodTypePredatorList = new List<string>();
        List<string> foodTypeHerbivoreList = new List<string>();
        public AbstractAnimal(string name, string habitat, double unitsToSquare, double age, double weight, double maxWeight)
        {
            Name = name;
            Habitat = habitat;
            UnitsToSquare = unitsToSquare;
            Age = age;
            Weight = weight;
            MaxWeight = maxWeight;
            foodTypePredatorList.Add("meat");
            foodTypePredatorList.Add("fish");
            foodTypeHerbivoreList.Add("leaves");
            foodTypeHerbivoreList.Add("grass");
            foodTypeHerbivoreList.Add("berries");
        }

        public void Feed(string eat, double foodWeight)
        {
            if(isPredator==true)
            {
                if(foodTypePredatorList.Contains(eat))
                {
                    Console.WriteLine($"{Name} has {foodWeight} kg of {eat}");
                }
                else
                {
                    Console.WriteLine($"{Name} doesn't eat {eat}");
                }
            }
            else if(isPredator==false)
            {
                if(foodTypeHerbivoreList.Contains(eat))
                {
                    Console.WriteLine($"{Name} has {foodWeight} kg of {eat}");
                }
                else
                {
                    Console.WriteLine($"{Name} doesn't eat {eat}");
                }
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

        public abstract void Play();
    }
}
