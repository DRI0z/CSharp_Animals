using ConsoleAppAnimals.Service.VehiculeService;

namespace ConsoleAppAnimals.Models.Animals
{
    public class Dragons : Animal, IPilotage
    {
        public override void Move()
        {
            Console.WriteLine($"{Name} Dragon Move");
        }

        public void Moove()
        {
            Console.WriteLine($"{Name} Dragon Moove");
        }

        public new void Sleep()
        {
            Console.WriteLine($"{Name} Dragon Sleep");
        }
    }
}
