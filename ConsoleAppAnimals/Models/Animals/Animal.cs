namespace ConsoleAppAnimals.Models.Animals
{
    public abstract class Animal
    {
        public string Name { get; private set; }

        public Animal()
        {
            Name = "Animal";
        }

        public abstract void Move();

        public virtual void Sleep()
        {
            Console.WriteLine($"{Name} Sleep");
        }
    }
}
