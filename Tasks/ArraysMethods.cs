using System;
using System.Collections.Generic;
using System.Text;

namespace Practise1.Tasks
{
    internal class ArraysMethods
    {
        public static int FindMax(int[] dig)
        {
            // создать массив, заполнить его входными данными в main
            // завести переменную (maxDig) для определения максимума, старт взять с 0 индекса массива, т.е. с первого числа/ящика
            // пройтись циклом по массиву, начинаем с 0
            // условие: если переменная меньше чем dig[i], то переменная равна dig[i]
            // возвращаем переменную (maxDig)
            // в main выводим ArraysMethods.FindMax(dig)

            int maxDig = dig[0];

            for (int i = 0; i < dig.Length; i++)
            {
                if (maxDig < dig[i])
                {
                    maxDig = dig[i];
                }
            }
            return maxDig;
        }

        public static int FindMin(int[] dig) 
        {
            int minDig = dig[0];

            for (int i = 0; i < dig.Length; i++) 
            {
                if (minDig > dig[i])
                {
                    minDig = dig[i];
                }
            }

            return minDig;
        }

        public static int SumPositive(int[] dig)
        {
            // используем существующий массив dig[]
            // создаем переменную для подсчета суммы положительных чисел
            // проходим циклом по массиву
            // условие: если dig[i] больше 0, то sum += dig[i]
            // возвращаем sum
            // в main выводим ArraysMethods.SumPositive(dig)

            int sum = 0;

            for (int i = 0; i < dig.Length; i++)
            {
                if (dig[i] > 0)
                {
                    sum += dig[i];
                }
            }

            return sum;
        }

        public static bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        public static int CountEven(int[] dig)
        {
            // создаем метод IsEven для четных чисел
            // используем существующий массив dig[]
            // заводим счетчик = 0
            // проходим циклом по массиву
            // условие: если dig[i] IsEven то счетчик++
            // возвращаем счетчик и выводим в main

            int count = 0;

            for (int i = 0; i < dig.Length; i++) 
            {
                if (IsEven(dig[i]))
                {
                    count++;
                }
            }

            return count;
        }

        public static int CountEqual(int[] dig, int x)
        {
            // создаем переменную счётчик
            // используем ранее созданный массив dig[]
            // проходим циклом по массиву
            // условие: если dig[i] == x то счетчик++
            // возвращаем счетчик
            // выводим в main ArraysMethods.CountEqual(dig)

            int count = 0;

            for (int i = 0; i < dig.Length; i++)
            {
                if (dig[i] == x)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
