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
            if(Weight+foodWeight<MaxWeight)
            {
                Weight=+foodWeight;
                result=$"{result}.{Name} is {Weight} kg now";
            }
            else if(Weight + foodWeight>=MaxWeight)
            {
                Weight=MaxWeight;
                result = $"{result}.{Name} is {MaxWeight} kg now";
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
