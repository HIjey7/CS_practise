using System;
using System.Collections.Generic;
using System.Text;

namespace Practise1.Tasks
{
    public class Enemy
    {
        public string Name { get; }
        public int Health { get; private set; }

        public Enemy (string name, int startHealth)
        {
            Name = name;
            Health = startHealth;
        }

        public void TakeDamage(int damage)
        {
            if (damage <= 0)
            {
                return;
            }

            Health -= damage;

            if (Health < 0)
            {
                Health = 0;
            }


        }

        public bool IsAlive()
        {
            if (Health > 0)
            {
                return true;
            }

            return false;
        }
    }
}
