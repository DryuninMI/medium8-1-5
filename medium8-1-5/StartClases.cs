﻿using System;
using System.Collections.Generic;
using System.Text;

namespace medium8_1_5
{    class Wombat
    {
        public int Health;
        public int Armor;

        public void TakeDamage(int damage)
        {
            Health -= damage - Armor;
            if (Health <= 0)
            {
                Console.WriteLine("Я умер");
            }
        }
    }

    class Human
    {
        public int Health;
        public int Agility;

        public void TakeDamage(int damage)
        {
            Health -= damage / Agility;
            if (Health <= 0)
            {
                Console.WriteLine("Я умер");
            }
        }
    }
}
