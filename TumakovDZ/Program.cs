using System;

namespace TumakovDZ
{
    internal class Program
    {
        static double Maximum(double a, double b)
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
        static void Swap(ref int x, ref int y)
        {
            (y, x) = (x, y);
        }
        static bool Factorial(int n, out long result)
        {
            try
            {
                checked
                {
                    result = 1;
                    for (int i = 2; i <= n; i++)
                    {
                        result *= i;
                    }
                }
                return true;
            }
            catch (OverflowException)
            {
                result = 0;
                return false;
            }
        }
        static long FactorialRec(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * FactorialRec(n - 1);
            }
        }
        static int NOD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        static int NOD(int a, int b, int c)
        {
            return NOD(NOD(a, b), c);
        }
        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 5.1\n");

            Console.WriteLine("Программа по представлению метода выводящего большое число из двух:");
            Console.WriteLine("Тест:");
            double num1 = 5;
            double num2 = 10;
            double maxNum = Maximum(num1, num2);
            Console.WriteLine($"Максимальное значение из {num1} и {num2}: {maxNum}");

            Console.WriteLine("\nУпражнение 5.2\n");

            Console.WriteLine("Программа по представлению метода выводящего результат замены двух значений переменных:");
            Console.WriteLine("Тест:");
            int a2 = 10;
            int b2 = 20;
            Console.WriteLine($"До обмена: a = {a2}, b = {b2}");
            Swap(ref a2, ref b2);
            Console.WriteLine($"После обмена: a = {a2}, b = {b2}");

            Console.WriteLine("\nУпражнение 5.3\n");

            Console.WriteLine("Программа по представлению метода выводящего факториал введенного числа:");
            Console.WriteLine("Введите число у которого хотите узнать факториал:");
            Byte num3 = Byte.Parse(Console.ReadLine());
            bool success;
            success = Factorial(num3, out long factorial);
            if (success)
            {
                Console.WriteLine($"Факториал числа {num3} равен {factorial}.");
            }
            else
            {
                Console.WriteLine("Возникло переполнение при вычислении факториала.");
            }

            Console.WriteLine("\nУпражнение 5.4\n");

            Console.WriteLine("Программа по представлению метода выводящего факториал введенного числа(рекурсивного):");
            Console.WriteLine("Введите число у которого хотите узнать факториал:");
            Byte num4 = Byte.Parse(Console.ReadLine());
            long factorialrec = FactorialRec(num4);
            Console.WriteLine($"Факториал числа {num4} равен {factorialrec}.");

            Console.WriteLine("\nУпражнение 5.5\n");

            Console.WriteLine("Программа по представлению метода выводящего нод двух чисел:");
            Console.WriteLine("Введите числа у которых хотите узнать нод:");
            int a5 = int.Parse(Console.ReadLine());
            int b5 = int.Parse(Console.ReadLine());
            int nod = NOD(a5, b5);
            Console.WriteLine($"НОД({a5}, {b5}) = {nod}");
            Console.WriteLine("Программа по представлению метода выводящего нод трех чисел:");
            Console.WriteLine("Введите числа у которых хотите узнать нод:");
            int c5 = int.Parse(Console.ReadLine());
            int d5 = int.Parse(Console.ReadLine());
            int e5 = int.Parse(Console.ReadLine());
            int nod3 = NOD(c5, d5, e5);
            Console.WriteLine($"НОД({c5}, {d5}, {e5}) = {nod3}");

            Console.WriteLine("\nУпражнение 5.6\n");

            Byte num6 = Byte.Parse(Console.ReadLine());
            Console.WriteLine($"Fibonacci({num6}) = {Fibonacci(num6)}");


            Console.ReadKey();

        }
    }
}
