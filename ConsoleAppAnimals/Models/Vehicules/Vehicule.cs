using ConsoleAppAnimals.Service.VehiculeService;

namespace ConsoleAppAnimals.Models.Vehicules
{
    public class Vehicule : IPilotage
    {
        public string Name { get; set; }

        public void Moove() 
        {
            Console.WriteLine($"Vehicule {Name} Moove");
        }

    }
}
