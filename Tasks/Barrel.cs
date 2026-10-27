using System;
using System.Collections.Generic;
using System.Text;

namespace Practise1.Tasks
{
    public class Barrel : IDamageable
    {
        public int Durability {  get; private set; }

        public Barrel(int startDurability)
        {
            Durability = startDurability;
        }

        public void TakeDamage(int damage)
        {
            if (Durability <= 0 || damage <= 0)
            {
                return;
            }

            Durability -= damage;

            if (Durability < 0)
            {
                Durability = 0;
            }

            if (Durability == 0)
            {
                Console.WriteLine("Прочность равна 0 - бочка взорвана");
            }
        }

        public bool IsDestroyed => Durability <= 0;


    }
}
