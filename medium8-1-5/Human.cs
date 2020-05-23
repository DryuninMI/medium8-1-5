using System;

namespace medium8_1_5
{
    public class Human : Animal
    {
        public int Agility { get; private set; }

        public Human(int health, int agility) : base(health)
        {
            if(agility < 1)
            {
                throw new InvalidOperationException();
            }

            Agility = agility;
        }
        public override int CalculateDamage(int damage)
        {
            return damage / Agility;
        }
    }
}
