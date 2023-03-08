using ConsoleAppAnimals.Models;
using ConsoleAppAnimals.Models.Animals;
using ConsoleAppAnimals.Models.Vehicules;

namespace ConsoleAppAnimals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Griffin griffin = new Griffin("Griffin", "Rare");
            Dragons dragons = new Dragons("Dragon", "Rare");

            Dog max = new Dog("Max", "Commun");
            Dog rocky = new Dog("Rocky", "Commun");
            Dog sonny = new Dog("Sonny", "Commun");
            Dog snow = new Dog("Snow", "Commun");
            Dog sun = new Dog("Sun", "Commun");

            List<Animal> animals = new List<Animal> { griffin, dragons, rocky, max, sonny, snow, sun };

            IEnumerable<Animal> onlyRare = animals.Where(or => or.Rarity == "Rare");
                

            foreach(Animal animalRare in onlyRare)
            {
                Console.WriteLine($"Name {animalRare.Name}, Rarity : {animalRare.Rarity}");
            }


        }
    }
}