using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Aviary
    {
        public string AviaryName { get; protected set; }
        public string AviaryBiome { get; protected set; }
        public double AviarySquare { get; protected set; }
        List<AbstractAnimal> animalsInAviary=new List<AbstractAnimal>();
        {

    }
}
