using ConsoleAppAnimals.Models;

namespace ConsoleAppAnimals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animals chat = new Animals("Chat");
            Animals chien = new Animals("Chien");
            Animals animal = new Animals();

            chat.Sleep(); 
            chien.Move();
            animal.Sleep();
        }
    }
}