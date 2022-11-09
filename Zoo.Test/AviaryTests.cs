using NUnit.Framework.Constraints;
using Zoo.Animals;
using Zoo.Options;

namespace Zoo.Test
{
    public class AviaryTests
    {
        [TestCaseSource(typeof(AddAnimalTestCaseSource))]
        public void AddAnimalTest(AbstractAnimal animal, Aviary aviary,Aviary expectedAviary, Message expectedMessage)
        {
            Message actualMessage=aviary.AddAnimal(animal);
            Aviary actualAviary=aviary;
            Assert.AreEqual(expectedAviary, actualAviary);
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestCaseSource(typeof(MakeSoundAllTestCaseSource))]
        public void MakeSoundAllTest(Aviary aviary,Message expectedMessage)
        {
            Message actualMessage = aviary.MakeSoundAll();
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestCaseSource(typeof(RemoveAnimalTestCaseSource))]
        public void RemoveAnimalTest(AbstractAnimal animal,Aviary aviary,Aviary expectedAviary, Message expectedMessage)
        {
            Message actualMessage = aviary.RemoveAnimal(animal);
            Aviary actualAviary = aviary;
        }
    }

}