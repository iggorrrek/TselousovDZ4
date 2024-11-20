using System;


namespace FileDZ
{
    internal class Program
    {
        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static int CalculateStats(int[] numbers, out long product, ref double average)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Массив не может быть пустым.");
            }

            int sum = 0;
            product = 1;
            foreach (int number in numbers)
            {
                sum += number;
                product *= number;
            }

            double srarif = (double)sum / numbers.Length;

            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\nЗдание номер 1\n");

            Random random = new Random();
            int[] mas = new int[20];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = random.Next(); 
            }
            Console.Write("Исходный массив: ");
            PrintArray(mas);
            Console.WriteLine("Введите индекс первого элемента (от 1 до 20): ");
            int num1 = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Введите индекс второго элемента (от 1 до 20): ");
            int num12 = int.Parse(Console.ReadLine()) - 1;
            Swap(ref mas[num1], ref mas[num12]);
            Console.Write("Измененный массив: ");
            PrintArray(mas);

            Console.WriteLine("\nЗдание номер 2\n");
            
            int[] array = { 1, 2, 3, 4, 5 };
            double srarif = 0.0; // yt hf,jnftn не рабоьаеь ОБРАТИТЬ ВНИМАНИЕ
            int sum = CalculateStats(array, out long product, ref srarif);
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {product}");
            Console.WriteLine($"Среднее арифметическое: {srarif}");

            Console.ReadKey();
        }
    }
}
