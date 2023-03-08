using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimals.Models.Animals
{
    public class Dog : Animal
    {
        public Dog(string name, string rarity) 
        {
            Name = name;
            Rarity = rarity;
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} Dog Move");
        }

        public new void Sleep()
        {
            Console.WriteLine($"{Name} Dog Sleep");
        }
    }
}
