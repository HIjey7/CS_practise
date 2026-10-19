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

        public static bool Contains(int[] dig, int x)
        {
            // используем тот же массив dig[]
            // проходим циклом по массиву
            // условие: если dig[i] == x, то возвращаем true
            // если в цикле ничего не нашли, то возвращаем false

            for (int i = 0; i < dig.Length; i++)
            {
                if (dig[i] == x)
                {
                    return true;
                }
            }

            return false;
        }


        public static int SumEvenIndex(int[] mass)
        {
            // создать массив, в котором 8 целых чисел
            // создать метод с параметрами int[] mass
            // создать переменную суммы
            // пройтись циклом по массиву
            // условие: если индекс массива четный и элемент под этим индексом больше 5
            // то сумма = сумма + этот элемент
            // возвращаем сумму

            int sum = 0;

            for (int i = 0; i < mass.Length; i++)
            {
                if ( i %  2 == 0 &&  mass[i] > 5)
                {
                    sum += mass[i];
                }
            }

            return sum;
        }

        public static int IndexFirstElEqualTarget(int[] dig, int target)
        {
            // создаем массив int[] dig
            // создаем метод, в который передаем сам массив и target
            // проходим циклом по массиву
            // условие: если элемент в массиве равен таргету
            // то возвращаем i
            // return -1 после цикла если условие в цикле не выполнится

            for (int i = 0; i < dig.Length; i++)
            {
                if (dig[i] == target)
                {
                    return i;
                }
            }

            return -1;
        }

            public static int SumFromTo(int[] mass, int from, int to)
            {
            // заводим переменную суммы = 0
            // условие: если from больше чем to, то возвращаем -1
            // проходим циклом по массиву
            // если элемент массива больше либо равен from и меньше либо равен to, то закидываем элемент в сумму
            // возвращаем sum

            int sum = 0;

                if (from > to)
                {
                    return -1;
                }

                for (int i = 0; i < mass.Length; i++)
                {
                        if (from <= mass[i] && mass[i] <= to)
                        {
                            sum += mass[i];
                        }
                }

                return sum;

            } 

        public static bool IsPositive(int value)
        {
            return (value > 0);
        }


        public static bool PositivesNums(int[] nums, int k)
        {
            // создаем метод IsPositive который возвращаем value > 0
            // заводим переменную счетчик
            // проверка если k меньше равно 0 то возвращаем false
            // проходим циклом по массиву
            // проверям положительный ли элемент массива и прибавляем к счетчику 1
            // если счетчик равен к, то возвращаем True
            // возвращаем false

            int count = 0;
            
            if (k <= 0)
            {
                return false;
            }

            for (int i = 0; i < nums.Length; i++) 
            {
                    if (IsPositive(nums[i]))
                    {
                        count++;
                    }

                    if (count == k)
                    {
                        return true;
                    }
            }

            return false;
        }

        public static void SetFirstToZero(int[] arr)
        {
            arr[0] = 0;
        }

        public static void SetNegativeToZero(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = 0;
                }
            }
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0;i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public static void MultiplyAll(int[] arr, int k)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= k;
            }
        }

        public static void SwapFirstAndLast(int[] arr)
        {
            // если элементов меньше двух, то  выходим и ничего не делаем
            // сохраняем первый эл массива во временную переменную
            // записываем последний элемент в первый, а первый из временной переменной в последний

                if (arr.Length < 2)
                {
                    return;
                }

                int temp = arr[0];
                arr[0] = arr[arr.Length - 1];
                arr[arr.Length - 1] = temp;
        }
    }
}
