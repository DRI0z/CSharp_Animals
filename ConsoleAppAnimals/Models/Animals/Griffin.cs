namespace ConsoleAppAnimals.Models.Animals
{
    public class Griffin : Animal
    {
        public Griffin(string name, string rarity) 
        {
            Name = name;
            Rarity = rarity;
        }
        public override void Move()
        {
            Console.WriteLine($"{Name} Griffin Move");
        }

        public new void Sleep()
        {
            Console.WriteLine($"{Name} Griffin Sleep");
        }
    }
}
