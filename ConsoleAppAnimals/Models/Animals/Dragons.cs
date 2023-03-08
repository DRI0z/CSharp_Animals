namespace ConsoleAppAnimals.Models.Animals
{
    public class Dragons : Animal
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
