using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Zoo.Animals;
using Zoo.Options;

namespace Zoo.Test
{
    public class AddAnimalTestCaseSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            AbstractAnimal animal = new TigerAnimal("Barsik", 2);
            Aviary aviary = new Aviary("Volyer", BiomType.Jungle, 50);
            Aviary expectedAviary=new Aviary("Volyer", BiomType.Jungle, 50);
            expectedAviary.Animals.Add(animal);
            Message expectedMessage = new Message()
            {
                Text = $"{animal.Name} lives in {aviary.Name} now",
                SenderType = "Aviary",
                SenderName = aviary.Name,
                MessageType = MessageType.AddAnimalSuccess
            };
            yield return new object[] { animal, aviary, expectedAviary, expectedMessage };
        }
    }

    public class MakeSoundAllTestCaseSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            AbstractAnimal lion = new LionAnimal("Mufasa", 5);
            AbstractAnimal giraffe = new GiraffeAnimal("Barsik", 5);
            Aviary aviary=new Aviary("Volyer",BiomType.Savannah, 50);
            aviary.AddAnimal(giraffe);
            aviary.AddAnimal(lion);
            Message expectedMessage = new Message()
            {
                Text = "All animals made sound",
                SenderType = "Aviary",
                SenderName = aviary.Name,
                MessageType = MessageType.AnimalMakeSound
            };
            yield return new object[]{ aviary, expectedMessage };
            
        }
    }
}
