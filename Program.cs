namespace Practise1
{
    internal class Program
    {
        static void Main(string[] args)
        {



            // Task1();
            // Task2();
            // Task3();
            // Task4();
            // Task5();
            // Task7(); 
            // Task8();
            Task9();
        }

        // task 1
        static void Task1()
        {
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, " + name);

        }
        // task 2

        static void Task2()
        {
            Console.WriteLine("Введите первое число: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int y = int.Parse(Console.ReadLine());

            int sum = x + y;
            int raz = x - y;
            int proizv = x * y;

            Console.WriteLine("Сумма: " + sum + '\n' + "Разность: " + raz + '\n' + "Произведение: " + proizv);
        }

        // task 3
        static void Task3()
        {
            Console.WriteLine("Введите число: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Число " + x + " чётное");
            }
            else if (x % 2 != 0)
            {
                Console.WriteLine("Число " + x + " нечётное");
            }
        }

        // task 4 
        static void Task4()
        {
            Console.WriteLine("Введите число: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }

        // task 5

        static void Task5()
        {
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

                Console.WriteLine("Наибольшее число: " + Max(15, 15));
            }
        }

        static void Task7() 
        {
            Console.WriteLine("Введите число: ");

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) 
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
                
        }

        static void Task8()
        {
            Console.WriteLine("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i ++)
            {
                sum += i;
                
            }
            Console.WriteLine(sum);
        }

        static void Task9()
        {
            Console.WriteLine("Сколько чисел? ");
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());

            }

            int max = nums[0];

            for (int i = 1; i < n; i++) 
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }

            Console.WriteLine("Ответ: " + max);
        }

    }
}
