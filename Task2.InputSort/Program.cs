using System;

namespace Task2.InputSort
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int n;
            while (true)
            {
                Console.Write("Введите количество элементов: ");
                string input = Console.ReadLine();

                try
                {
                    n = int.Parse(input);
                    if (n > 0) break;
                    Console.WriteLine("Ошибка: N должно быть больше 0!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Введите целое число!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: Число слишком большое!");
                }
            }

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    Console.Write($"Элемент [{i}]: ");
                    try
                    {
                        array[i] = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка: введите целое число!");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Ошибка: число слишком большое!");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Исходный массив:  " + string.Join(", ", array));

            Console.Write("Обратный порядок: ");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i]);
                if (i > 0) Console.Write(", ");
            }
            Console.WriteLine();

            int[] sorted = (int[])array.Clone();
            Array.Sort(sorted);
            Console.WriteLine("Отсортированный:  " + string.Join(", ", sorted));

            int max = array[0];
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
            }
            Console.WriteLine($"Максимум: {max}");
            Console.WriteLine($"Минимум: {min}");

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}