using Practise1.Tasks;
using System.Runtime.CompilerServices;

namespace Practise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Loops.Task1();
            // Loops.Task2();
            // Loops.Task3();
            // Conditions.Task8();
            // Conditions.Task9();
            // Conditions.Task10();
            // Arrays.Task11();
            // Arrays.Task12();
            // Arrays.Task13();
            // Arrays.Task14();

            ////FindMax | FindMin
            //int[] dig = [4, 8, 15];

            //Console.WriteLine("Массив: ");

            //for (int i = 0; i < dig.Length; i++)
            //{
            //    Console.WriteLine($"Элемент [{i}] = {dig[i]}");
            //}

            //Console.WriteLine("\nНаибольшее число: " + ArraysMethods.FindMax(dig));
            //Console.WriteLine("Наименьшее число: " + ArraysMethods.FindMin(dig));

            //// SumPositive
            //Console.WriteLine("Сумма положительных чисел: " + ArraysMethods.SumPositive(dig));

            //// CountEven
            //Console.WriteLine("Кол-во чётных чисел массива: " + ArraysMethods.CountEven(dig));

            //// CountEquals
            //Console.WriteLine("Кол-во 'x' в массиве: " + ArraysMethods.CountEqual(dig, 5));

            //// Contains
            //Console.WriteLine("Наличие 'x' в массиве: " + ArraysMethods.Contains(dig, 8));

            //// SumEvenIndex
            //int[] mass = [1, -5, 10, 7, 3, 5, 1000, 3789];

            //Console.WriteLine("Сумма элементом четных индексов, где элементы > 5: " + ArraysMethods.SumEvenIndex(mass));

            //
            //int[] dig = [5, 5, 9, 13, 5, 4, 0];

            //Console.WriteLine(ArraysMethods.IndexFirstElEqualTarget(dig, 5));
            //Console.WriteLine(ArraysMethods.IndexFirstElEqualTarget(dig, 4));

            //int[] mass = [15, 49, 7, 0, 4, -10, 121];

            //Console.WriteLine(ArraysMethods.SumFromTo(mass, 1, 50));
            //Console.WriteLine(ArraysMethods.SumFromTo(new int[] { 5, 5, 3 }, 5, 5)); 
            //Console.WriteLine(ArraysMethods.SumFromTo(mass, 101, 9));

            //int[] nums = [-10, 5, 0, -3, 12, 16, 90, 1, 5];

            //Console.WriteLine(ArraysMethods.PositivesNums(nums, 3)); // проверка работоспособности || ожидаю true
            //Console.WriteLine(ArraysMethods.PositivesNums(nums, 6)); // проверка равно k || ожидаю true
            //Console.WriteLine(ArraysMethods.PositivesNums(nums, 7)); // проверка больше длины массива || ожидаю false
            //Console.WriteLine(ArraysMethods.PositivesNums(nums, 0)); // проверка k = 0 || ожидаю false
            //Console.WriteLine(ArraysMethods.PositivesNums(new int[]  { }, 1)); // проверка пустого массива и k = 1 || ожидаю false


            //int[] nums = [7, 8, 9];
            //Console.WriteLine(nums[0]);    // что здесь?
            //ArraysMethods.SetFirstToZero(nums);
            //Console.WriteLine(nums[0]);

            //SetNegativeToZero
            //int[] arr = [-3, 12, -9, -15, -100, 2, 17];

            //ArraysMethods.PrintArray(arr);

            //ArraysMethods.SetNegativeToZero(arr);
            //ArraysMethods.PrintArray(arr);

            //MultiplyAll
            //int[] arr = [1, 2, 3, 4];
            //int[] one = [3];

            ////ArraysMethods.PrintArray(arr);
            ////ArraysMethods.MultiplyAll(arr, 2);
            ////ArraysMethods.PrintArray(arr);

            //ArraysMethods.PrintArray(arr);
            //ArraysMethods.SwapFirstAndLast(arr);
            //ArraysMethods.PrintArray(arr);

            //ArraysMethods.SwapFirstAndLast(one);
            //ArraysMethods.PrintArray(one); // ожидаю: 3
            //ArraysMethods.SwapFirstAndLast(new int[] { }); // ожидаю: программа не падает


            //int[] digits = [14, 2, 0, -15, 20, 5, 7, -3];

            //ArraysMethods.PrintArray(digits);

            //ArraysMethods.ClampToRange(digits, -1, 10);
            //ArraysMethods.PrintArray(digits);

            int[] numbers = [9, -3, 5, 7, 0, 11, -7, -23, 90];
            ArraysMethods.PrintArray(numbers);

            //ArraysMethods.PrintArray(ArraysMethods.ReturnNewArr(numbers, -1, 11));

            Console.WriteLine(ArraysMethods.CountOfRange(numbers, -1, 11));
            
        }
    }
}
