using Zoo;
using Zoo.Animals;
using Zoo.Options;

TigerAnimal tigerBarsik = new TigerAnimal ("Barsik", 1);
Console.WriteLine(tigerBarsik.Play());
Console.WriteLine(tigerBarsik.MakeSound());
Console.WriteLine(tigerBarsik.Feed(FoodType.Meat,5));
Console.WriteLine(tigerBarsik.Feed(FoodType.Meat, 25));
Console.WriteLine(tigerBarsik.Feed(FoodType.Meat, 1));


Aviary jungleAviary = new Aviary("JungleAviary", BiomType.Jungle, 10.5);
Console.WriteLine(jungleAviary.AddAnimal(tigerBarsik));