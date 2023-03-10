using ConsoleAppAnimals.Models;
using ConsoleAppAnimals.Models.Animals;
using ConsoleAppAnimals.Models.Vehicules;

namespace ConsoleAppAnimals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Griffin griffin = new Griffin("Griffin", "Rare", 10);
            Dragons dragons = new Dragons("Dragon", "Rare", 12);

            Dog max = new Dog("Max", "Commun", 15);
            Dog rocky = new Dog("Rocky", "Commun", 17);
            Dog sonny = new Dog("Sonny", "Commun", 8);
            Dog snow = new Dog("Snow", "Commun", 6);
            Dog sun = new Dog("Sun", "Commun", 20);

            List<Animal> animals = new List<Animal> { griffin, dragons, rocky, max, sonny, snow, sun };

            IEnumerable<Animal> onlyRare = animals.Where(or => or.Rarity == "Rare").ToList();
            IEnumerable<Animal> onlyChild = animals.Where(or => or.Old >= 10 && or.Old <= 15).ToList();

            foreach(Animal animalRare in onlyRare)
            {
                Console.WriteLine($"Name {animalRare.Name}, Rarity : {animalRare.Rarity}");
            }

            foreach(Animal animalChild in onlyChild)
            {
                Console.WriteLine($"Name {animalChild.Name}, Old : {animalChild.Old}");
            }


        }
    }
}