using System;

namespace medium8_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wombat");

            Animal wombat = new Wombat(10, 5);
            wombat.TakeDamage(5);
            wombat.TakeDamage(10);
            wombat.TakeDamage(16);

            Console.WriteLine("Human");

            Animal human = new Human(20, 2);
            human.TakeDamage(14);
            human.TakeDamage(10);
            human.TakeDamage(15);
            human.TakeDamage(2);
        }
    }
}
