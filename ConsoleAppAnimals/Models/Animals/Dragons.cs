using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimals.Models.Animals
{
    public class Dragons : Animals
    {
        public override void Move()
        {
            Console.WriteLine(Name + " Dragon Move");
        }

        public new void Sleep()
        {
            Console.WriteLine(Name + " Dragon Sleep");
        }
    }
}
