using System;
using System.Security.Cryptography.X509Certificates;


namespace Zoo
{
    public abstract class AbstractAnimal
    {
        public string Name { get; set; }
        public string Biome { get;  protected set; }
        public double MaxFoodForDay { get; set; }
        public double UnitsToSquare { get; set; }
        public double Age { get;set; }
        public bool isPredator { get; protected set; }
        protected string _sound;

        List<string> foodType;
        public AbstractAnimal(string name, string biome, double unitsToSquare, double age, double maxFoodForDay)
        {
            Name = name;
            Biome = biome;
            UnitsToSquare = unitsToSquare;
            Age = age;
            MaxFoodForDay = maxFoodForDay;
        }

        public string Feed(string eat, double foodWeight)
        {
            string result="";
            if(foodType.Contains(eat) && foodWeight<=MaxFoodForDay)
            {
                result = $"{Name} ate {foodWeight} kg of {eat}";
            }
            else
            {
                result = $"{Name} doesn't want to eat {eat}";
            }
            return result;
        }

        public string MakeSound()
        {
            string result = $"{Name}:{_sound}";
            return result;
        }

        public abstract string Play();
    }
}
