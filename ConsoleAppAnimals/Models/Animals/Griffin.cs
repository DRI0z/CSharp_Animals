using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimals.Models.Animals
{
    public class Griffin : Animals
    {
        public override void Move()
        {
            Console.WriteLine(Name + " Griffin Move");
        }

        public new void Sleep()
        {
            Console.WriteLine(Name + " Griffin Sleep");
        }
    }
}
