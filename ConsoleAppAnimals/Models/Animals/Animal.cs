namespace ConsoleAppAnimals.Models.Animals
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Rarity { get; set; } 
        public int Old { get; set; } 

        public Animal()
        {

        }

        public abstract void Move();

        public virtual void Sleep()
        {
            Console.WriteLine($"{Name} Sleep");
        }
    }
}
