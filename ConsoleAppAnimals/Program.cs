using ConsoleAppAnimals.Models;

namespace ConsoleAppAnimals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animals chat = new Animals("Minou");
            Animals chien = new Animals("Waouf");

            chat.Sleep();
            chien.Move();
        }
    }
}