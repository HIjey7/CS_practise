using System;
using System.Collections.Generic;
using System.Text;

namespace Practise1.Tasks
{
    interface IDamageable
    {
        // 1. Нужно описать два члена, один для получения урона, второй для проверки на "уничтожен"
        // 2. Создаем метод TakeDamage(int damage) - этот метод принимает число(урон) и отнимает этот урон от чего то (здоровье или прочность)
        // 3. Создаем метод IsDestroyed() - этот метод проверяет уничтожен или нет 

        void TakeDamage(int damage);
        bool IsDestroyed { get; }

    }
}
