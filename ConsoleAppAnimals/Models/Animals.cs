using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimals.Models
{
    public class Animals
    {
        public string Name;

        public Animals() 
        {
            this.Name = "Animal sans nom";
        }

        public Animals(string Name)
        {
            this.Name = Name;
        }

        public void Move()
        {
            Console.WriteLine(Name + " Move");
        }

        public void Sleep()
        {
            Console.WriteLine(Name + " Sleep");
        }
        
    }
}
