using Project_RPG_Heroes.Characters;

namespace Project_RPG_Heroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mage = new Mage("New Mage");

            Console.WriteLine(mage.Name);
            Console.WriteLine(mage.Level);

        }
    }
}