namespace ConsoleAppAnimals.Models.Animals
{
    public class Griffin : Animal
    {
        public Griffin(string name, string rarity, int old) 
        {
            Name = name;
            Rarity = rarity;
            Old = old;
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
