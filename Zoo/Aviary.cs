using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Aviary //Вольер
    {
        public string Name { get; protected set; }
        public string Biome { get; protected set; }
        public double Square { get; protected set; }
        public List<AbstractAnimal> Animals { get; protected set; }

        public Aviary(string name, string biome, double square)
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
                    Text = $"not enough space for {animal.Name} in {Name}"
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
    }
}
