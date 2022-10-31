using System;
using System.Security.Cryptography.X509Certificates;


namespace Zoo
{
    public abstract class AbstractAnimal
    {
        public string Name { get; set; }
        public string Habitat { get;  protected set; }
        public double MaxFoodForDay { get; set; }
        public double UnitsToSquare { get; set; }
        public double Age { get;set; }
        public bool isPredator { get; protected set; }
        protected string _sound;

        List<string> foodTypePredators;
        List<string> foodTypeHerbivores = new List<string>();
        public AbstractAnimal(string name, string habitat, double unitsToSquare, double age, double maxFoodForDay)
        {
            Name = name;
            Habitat = habitat;
            UnitsToSquare = unitsToSquare;
            Age = age;
            MaxFoodForDay = maxFoodForDay;
            foodTypePredators = new List<string>()
            {
                "asdfg",
                "bghgrtr"
            };
        }

        public string Feed(string eat, double foodWeight)
        {
            string result="";
            if(isPredator==true)
            {
                if(foodTypePredatorList.Contains(eat))
                {
                    result=$"{Name} has {foodWeight} kg of {eat}";
                }
                else
                {
                    result=$"{Name} doesn't eat {eat}";
                }
            }
            else if(isPredator==false)
            {
                if(foodTypeHerbivoreList.Contains(eat))
                {
                    result=$"{Name} has {foodWeight} kg of {eat}";
                }
                else
                {
                    result=$"{Name} doesn't eat {eat}";
                }
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
