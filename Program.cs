using Practise1.Tasks;

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

            //FindMax | FindMin
            int[] dig = [4, 8, 15];

            Console.WriteLine("Массив: ");

            for (int i = 0; i < dig.Length; i++)
            {
                Console.WriteLine($"Элемент [{i}] = {dig[i]}");
            }

            Console.WriteLine("\nНаибольшее число: " + ArraysMethods.FindMax(dig));
            Console.WriteLine("Наименьшее число: " + ArraysMethods.FindMin(dig));

            // SumPositive
            Console.WriteLine("Сумма положительных чисел: " + ArraysMethods.SumPositive(dig));

            // CountEven
            Console.WriteLine("Кол-во чётных чисел массива: " + ArraysMethods.CountEven(dig));

            // CountEquals
            Console.WriteLine("Кол-во 'x' в массиве: " + ArraysMethods.CountEqual(dig, 5));

            // Contains
            Console.WriteLine($"Наличие 'x' в массиве: " + ArraysMethods.Contains(dig, 8));
        }
    }
}
