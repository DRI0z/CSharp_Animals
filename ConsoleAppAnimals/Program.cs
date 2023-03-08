using ConsoleAppAnimals.Models;
using ConsoleAppAnimals.Models.Animals;

namespace ConsoleAppAnimals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Griffin griffin = new Griffin();
            Dragons dragons = new Dragons();

            griffin.Sleep();
            griffin.Move();

            dragons.Move();
            dragons.Sleep();

        }
    }
}