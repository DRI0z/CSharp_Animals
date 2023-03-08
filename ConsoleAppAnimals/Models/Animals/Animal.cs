using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimals.Models.Animals
{
    public abstract class Animals
    {
        public string Name { get; private set; }

        public Animals()
        {
            Name = "Animal";
        }

        public abstract void Move();

        public void Sleep()
        {
            Console.WriteLine("Animal Sleep");
        }
    }
}
