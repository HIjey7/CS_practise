using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Practise1.Tasks
{
    internal class Arrays
    {
        public static void Task11()
        {
            // завести счетчик, создать массив с размерностью 5, заполнить массив входными данными, пройтись циклом по массиву начиная с индекса 0, условие, если в массиве есть значение ниже 0, то счетчик + 1. Выводим счетчик

            int count = 0;

            int[] dig = new int[5];

            dig[0] = 3;
            dig[1] = -1;
            dig[2] = 4;
            dig[3] = -5;
            dig[4] = 2;

            for (int i = 0; i < dig.Length; i++)
            {
                if (dig[i] < 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        public static void Task12()
        {
            // создать тот же массив что и в прошлой задаче, пройтись циклом по массиву, начиная с 1, т.к. будет произведение, переменной присвоить значение массива и переменную умножить на себя в цикле

            int proizv = 1;
            int[] dig = new int[5];

            dig[0] = 3;
            dig[1] = -1;
            dig[2] = 4;
            dig[3] = -5;
            dig[4] = 2;


            for (int i = 0; i < dig.Length; i++)
            {
                proizv *= dig[i];
            }

            Console.WriteLine(proizv);
        }


        public static void Task13()
        {
            // создать массив, заполнить массив входными данными, пройтись циклом по массиву, если число больше 6 И меньше 15 то выводим его

            int[] dig = new int[5];

            dig[0] = 5;
            dig[1] = 12;
            dig[2] = 7;
            dig[3] = 20;
            dig[4] = 3;

            for (int i = 0; i < dig.Length;i++)
            {
                if (6 < dig[i] && dig[i] < 15)
                {
                    Console.WriteLine(dig[i]);
                }
            }
        }

        public static void Task14()
        {
            // завести переменную для подсчета суммы, создать массив, заполнить его входными данными, пройтись циклом по массиву, условие: если i делится на 2 без остатка, то sum += dig[i]

            int sum = 0;

            int[] dig = new int[5];

            dig[0] = 4;
            dig[1] = 1;
            dig[2] = 6;
            dig[3] = 2;
            dig[4] = 8;

            for (int i = 0; i < dig.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum += dig[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
