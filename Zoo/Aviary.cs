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
        
        public Aviary(string name, string biome, double square)
        {
            Name=name;
            Biome=biome;
            Square=square;
            List<AbstractAnimal> animals;
        }
    }
}
