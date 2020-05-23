using System;

namespace medium8_1_5
{
    public abstract class Animal
    {
        public int Health { get; private set; }

        public Animal(int health)
        {
            if(health < 1)
            {
                throw new InvalidOperationException();
            }

            Health = health;
        }

        public void TakeDamage(int damage)
        {
            if(damage < 0)
            {
                throw new InvalidOperationException();
            }

            Health -= CalculateDamage(damage);

            if (Health <= 0)
            {
                Console.WriteLine("Я умер");
            }
            else
            {
                Console.WriteLine("Мое ХП: {0}", Health);
            }
        }
        public abstract int CalculateDamage(int damage);
    }
}
