using System;
using System.Collections.Generic;
using System.Text;

namespace Practise1.Tasks
{
    internal class Conditions
    {
        public static void Task8()
        {
            // завести три переменные для оценок, первое условие, if a == 5 && b == 5 && c == 5 то выводим "Отличник", второе условие если все три не ниже 4 то выводим "Хорошист", иначе выводим "Есть тройки"

            int a = 5; int b = 4; int c = 5;

            if (a == 5 && b == 5 && c == 5)
            {
                Console.WriteLine("Отличник");
            }
            else if (a >= 4 && b >= 4 && c >= 4)
            {
                Console.WriteLine("Хорошист");
            }
            else
            {
                Console.WriteLine("Есть тройки");
            }
        }

        public static void Task9() 
        {
            // цикл начиная с 1 до 20 включительно, условие: если переменная делится на 2 без остатка выводим переменную + "чётное", иначе "нечётное"

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " чётное");
                } else
                {
                    Console.WriteLine(i + " нечётное");
                }
            }
        }

        public static void Task10()
        {
            // завести переменную счетчик, цикл начиная с 1 до 50 включительно, условие если i делится на 7 без остатка - счетчик + 1. Выводим счетчик

            int count = 0;

            for (int i = 1; i <= 50; i++)
            {
                if (i % 7 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
