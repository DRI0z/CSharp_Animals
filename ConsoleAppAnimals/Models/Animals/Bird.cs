﻿using ConsoleAppAnimals.Service.AnimalService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimals.Models.Animals
{
    public class Bird : Animal, IFly
    {
        public Bird(string name, string rarity)
        {
            Name = name;
            Rarity = rarity;
        }
        public override void Move()
        {
            Console.WriteLine($"{Name} Move");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} Fly");
        }
    }
}