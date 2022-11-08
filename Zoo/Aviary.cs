using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Animals;
using Zoo.Options;

namespace Zoo
{
    public class Aviary //Вольер
    {
        public string Name { get; protected set; }
        public BiomType Biome { get; protected set; }
        public double Square { get; protected set; }
        public List<AbstractAnimal> Animals { get; protected set; }

        public Aviary(string name, BiomType biome, double square)
        {
            Name=name;
            Biome=biome;
            Square=square;
            Animals = new List<AbstractAnimal>();
        }

       public Message AddAnimal(AbstractAnimal animal)
        {
            if(Biome!=animal.Biome)
            {
                return new Message()
                {
                    Text = $"{animal.Name} doesn't live in {Biome}",
                    SenderType = "Aviary",
                    SenderName = Name,
                    MessageType = MessageType.AddAnimalFailure
                };
            }

            else if (FreeSquare() < animal.SquareToUnit)
            {
                return new Message()
                {
                    Text = $"not enough space for {animal.Name} in {Name}",
                    SenderType = "Aviary",
                    SenderName = Name,
                    MessageType = MessageType.AddAnimalFailure
                };
            }

            else if(!IsAnimalMatch(animal))
            {
                return new Message()
                {
                    Text = $"{animal.Name} doesn't live with animals in aviary",
                    SenderType = "Aviary",
                    SenderName = Name,
                    MessageType = MessageType.AddAnimalFailure
                };
            }

            else
            {
                Animals.Add(animal);
                return new Message()
                {
                    Text = $"{animal.Name} lives in {Name} now",
                    SenderType = "Aviary",
                    SenderName = Name,
                    MessageType = MessageType.AddAnimalSuccess
                };
            }
        }

        private bool IsAnimalMatch (AbstractAnimal animal)
        {
            foreach(AbstractAnimal a in Animals)
            {
                if((a.IsPredator || animal.IsPredator) && animal.Species!=a.Species)
                {
                    return false;
                }
            }
            return true;
        }

        private double FreeSquare()
        {
            double freeSquare = Square;
            foreach(AbstractAnimal aviaryAnimal in Animals )
            {
                freeSquare -= aviaryAnimal.SquareToUnit;
            }
            return freeSquare;
        }

        public Message FeedAnimals (FoodType feederEat, double feederFoodWeight)
        {
            int animalQuantity=Animals.Count;
            double foodForEach=feederFoodWeight/animalQuantity;
            if(feederFoodWeight<=0)
            {
                throw new ArgumentException("weight of food cant be zero or less");
            }
            if(animalQuantity == 0)
            {
                return new Message()
                {
                    Text=$"there are no animals in aviary",
                    SenderType="Aviary",
                    SenderName=Name,
                    MessageType = MessageType.EmptyAviary
                };
            }
            else
            {
                foreach (AbstractAnimal animal in Animals)
                {
                    animal.Feed(feederEat, foodForEach);
                    feederFoodWeight -= foodForEach;
                }
                return new Message()
                {
                    Text = $"{foodForEach}kg of {feederEat} is eaten",
                    SenderType = "Aviary",
                    SenderName = Name,
                    MessageType = MessageType.AnimalFeed
                };
            }
        }

        public Message RemoveAnimal(AbstractAnimal animal)
        {
            if(Animals.Contains(animal))
            {
                Animals.Remove(animal);
                return new Message()
                {
                    Text = $"{animal.Name} removed from {Name}",
                    SenderType = "Aviary",
                    SenderName = Name,
                    MessageType = MessageType.AnimalRemove
                };
            }
            else
            {
                return new Message()
                {
                    Text = $"{animal.Name} don't live in {Name}",
                    SenderType = "Aviary",
                    SenderName = Name,
                    MessageType = MessageType.AnimalRemoveException
                };
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is Aviary aviary &&
                   Name == aviary.Name &&
                   Biome == aviary.Biome &&
                   Square == aviary.Square &&
                   Animals.Count == aviary.Animals.Count;
        }
    }
}
