using System;

namespace medium8_1_5
{
    public class Wombat : Animal
    {
        public int Armor { get; private set; }

        public Wombat(int health, int armor) : base(health)
        {
            if(armor < 0)
            {
                throw new InvalidOperationException();
            }

            Armor = armor;
        }
        public override int CalculateDamage(int damage)
        {
            return damage - Armor;
        }
    }
}
