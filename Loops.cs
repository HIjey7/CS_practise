using System;
using System.Collections.Generic;
using System.Text;

namespace Practise1
{
    internal class Loops
    {
        // заводим переменную со значением 7, циклом перебираем от 1 до 10 включительно, i ++ и переменную умножаем на i в цикле и выводим значения

        public static void Task1()
        {
            int num = 7;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + num * i);
            }

        }


        public static void Task2()
        {
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    if (i == 30)
                    {
                        Console.Write("Fizz");
                    }
                    else
                    {
                        Console.Write("Fizz, ");
                    }
                }
                else
                {
                    Console.Write(i + ", ");
                }
            }
        }


       public static void Task3()
        {
            int count = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    count += 1;
                }
            }

            Console.WriteLine(count);
        }
    }
}
