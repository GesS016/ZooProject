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
        }

        public string AddAnimal(AbstractAnimal animal)
        {
            string result = "";
            if(Biome==animal.Biome)
            {
                if(animal.IsPredator)
                {
                    if (Animals != null)
                    {
                      foreach(AbstractAnimal aviaryAnimal in Animals )
                      {
                        if(aviaryAnimal.Species==animal.Species)
                        {
                           if(animal.SquareToUnit <= FreeSquare())
                            {
                              Animals.Add(animal);
                              result= $"{animal.Name} lives in {Name} now";
                            }
                           else
                            {
                              result = $"not enough space for {animal.Name} in {Name} ";
                            }
                        }
                        else
                        {
                            result = $"{animal.Species}s don't live in {Name} ";
                        }
                      }
                    }
                    else
                    {
                        Animals.Add(animal);
                        result = $"{animal.Name} lives in {Name} now";
                    }
                }
                else // if animal is herbivore
                {
                    if(Animals!=null)
                    {
                      foreach(AbstractAnimal aviaryAnimal in Animals)
                      {
                        if(!aviaryAnimal.IsPredator)
                        {
                            if(animal.SquareToUnit<=FreeSquare())
                            {
                                Animals.Add(animal);
                                result= $"{animal.Name} lives in {Name} now";
                            }
                            else
                            {
                               result = $"not enough space for {animal.Name} in {Name} ";
                            }
                        }
                        else
                        {
                            result = $"{Name} is for predators";
                        }
                      }
                    }
                    else
                    {
                        Animals.Add(animal);
                        result = $"{animal.Name} lives in {Name} now";
                    }
                }
            }
            return result;
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
