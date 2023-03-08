using ConsoleAppAnimals.Models;
using ConsoleAppAnimals.Models.Animals;
using ConsoleAppAnimals.Models.Vehicules;

namespace ConsoleAppAnimals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Griffin griffin = new Griffin();
            Dragons dragons = new Dragons();

            Vehicule vehicule = new Vehicule();

            griffin.Sleep();
            griffin.Move();

            dragons.Move();
            dragons.Moove();
            dragons.Sleep();

            vehicule.Name = "Citroën";
            vehicule.Moove();
        }
    }
}