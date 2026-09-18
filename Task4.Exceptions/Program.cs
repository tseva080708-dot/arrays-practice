using System;

namespace Task4.Exceptions
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Массив из 5 элементов
            int[] array = new int[5];

            // === Заполнение с обработкой FormatException и OverflowException ===
            for (int i = 0; i < array.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Введите элемент [{i}]: ");

                    try
                    {
                        array[i] = int.Parse(Console.ReadLine());
                        break; // если успешно — выходим из while
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
            }

            // === Запрос индекса с обработкой IndexOutOfRangeException ===
            while (true)
            {
                Console.Write("\nВведите индекс для вывода (0-4): ");

                try
                {
                    int index = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Элемент[{index}] = {array[index]}");
                    break; // если успешно — выходим
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Введите целое число!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: Число слишком большое!");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Ошибка: Индекс вне границ массива.");
                }
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}