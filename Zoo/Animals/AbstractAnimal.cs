using System;
using System.Security.Cryptography.X509Certificates;
using Zoo.Options;

namespace Zoo.Animals
{
    public abstract class AbstractAnimal
    {
        public string Name { get; set; }
        public BiomType Biome { get; protected set; }
        public string Species { get; protected set; }
        public double EatenFood { get; protected set; }
        public double MaxFoodForDay { get; protected set; }
        public double SquareToUnit { get; set; }
        public double Age { get; set; }
        public bool IsPredator { get; protected set; }
        public List<FoodType> Food;
        protected string _sound;

        public AbstractAnimal(string name, double age)
        {
            EatenFood = 0;
            Name = name;
            Age = age;
            IsPredator = false;
        }

        public string Feed(FoodType eat, double foodWeight)
        {
            string result = "";
            if (!Food.Contains(eat))
            {
                return $"{Name} doesn't eat {eat}";
            }
            if (EatenFood + foodWeight <= MaxFoodForDay)
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

        public virtual string Play()
        {
            string result = $"{Name} plays";
            return result;
        }
    }
}
