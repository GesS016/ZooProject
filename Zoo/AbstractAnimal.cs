using System;
using System.Security.Cryptography.X509Certificates;


namespace Zoo
{
    public abstract class AbstractAnimal
    {
        public string Name { get; set; }
        public string Biome { get;  protected set; }
        public double EatenFood { get; protected set; }
        public double MaxFoodForDay { get; protected set; }
        public double UnitsToSquare { get; set; }
        public double Age { get;set; }
        public bool isPredator { get; protected set; }
        protected string _sound;

        public List<FoodType> Food;

        public AbstractAnimal(string name, string biome, double unitsToSquare, double age, double maxFoodForDay)
        {
           EatenFood =0;
            Name = name;
            Biome = biome;
            UnitsToSquare = unitsToSquare;
            Age = age;
            MaxFoodForDay = maxFoodForDay;
        }

        public string Feed(FoodType eat, double foodWeight)
        {
            string result="";
            if(!Food.Contains(eat))
            {
                return $"{Name} doesn't eat {eat}";
            }
            if(EatenFood+foodWeight <= MaxFoodForDay)
            {
                result = $"{Name} ate {foodWeight}kg of {eat}";
                EatenFood += foodWeight;
            }
            else
            {
                result = $"{foodWeight}kg is too much for {Name}";
            }
            return result;
        }

        public virtual string MakeSound()
        {
            string result = $"{Name}:{_sound}";
            return result;
        }

        public abstract string Play();
    }
}
