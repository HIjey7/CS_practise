namespace Practise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            /*
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, " + name);
            */

            // task 2

            /*
            Console.WriteLine("Введите первое число: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int y = int.Parse(Console.ReadLine());

            int sum = x + y;
            int raz = x - y;
            int proizv = x * y;

            Console.WriteLine("Сумма: " + sum + '\n' + "Разность: " + raz + '\n' + "Произведение: " + proizv);
            */

            // task 3

            /*Console.WriteLine("Введите число: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Число " + x + " чётное");
            } else if (x % 2 != 0) {
                Console.WriteLine("Число " + x + " нечётное");
            }*/

            // task 4 

            /*Console.WriteLine("Введите число: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                    Console.WriteLine(i);
                }*/

            // task 5


            static int Max(int a, int b)
            {
                if (a > b)
                {
                    return a;
                }

                else 
                {
                    return b;
                }
            }

            Console.WriteLine("Наибольшее число: " + Max(15, 15));
        }
    }
}
