using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYorkZoo
{
    public class Hippo
    {
        public string Name { get; set; }
        public string Habitat { get; protected set; }
        public double UnitsToSquareMeter { get; set; }

        public Hippo(string name, double unitsToSqaure)
        {
            Name = name;
            Habitat = "Savanna";
            UnitsToSquareMeter= unitsToSqaure;
        }
    }
}
