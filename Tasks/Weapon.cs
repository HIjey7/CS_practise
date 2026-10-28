using System;
using System.Collections.Generic;
using System.Text;

namespace Practise1.Tasks
{
    public class Weapon
    {
        public string Name { get; }
        public int Damage { get; }
        public int Strength { get; private set; }

        public Weapon(string name, int damage, int startStrength)
        {
            Name = name;
            Damage = damage;
            Strength = startStrength;
        }

        public int UseWeapon()
        {
            // 1. Если прочность Оружжия меньше либо равна 0, то возвращаем 0
            // 2. Когда используется Оружие мы отнимаем от прочности 1
            // 3. И возвращаем Урон

            if (Strength <= 0)
            {
                return 0;
            }

            Strength -= 1;

            return Damage;
        }

        public void StrikeOnTarget(IDamageable target)
        {
            if (target.IsDestroyed)
            {
                Console.WriteLine("Цель уничтожена");
                return;
            }

            target.TakeDamage(UseWeapon());
        }
    }
}
