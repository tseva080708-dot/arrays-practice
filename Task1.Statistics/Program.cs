using System;

namespace Task1.Statistics
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // === Шаг 1. Создаём массив из 10 случайных чисел [1, 100] ===
            Random rand = new Random();
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 101); // 101 — верхняя граница не включается, значит [1, 100]
            }

            // === Шаг 2. Выводим массив в одну строку через string.Join ===
            Console.WriteLine("Массив: " + string.Join(", ", numbers));

            // === Шаг 3. Сумма всех элементов ===
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"Сумма: {sum}");

            // === Шаг 4. Произведение всех элементов ===
            // Используем long, чтобы не переполнить int (10 чисел по 100 = 10^20, int максимум ~2*10^9)
            long product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            // Формат "E2" даёт экспоненциальную запись типа 1.23E+015 — как в примере
            Console.WriteLine($"Произведение: {product:E2}");

            // === Шаг 5. Количество чётных чисел ===
            int evenCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenCount++;
                }
            }
            Console.WriteLine($"Чётных чисел: {evenCount}");

            // === Шаг 6. Среднее арифметическое ===
            double average = (double)sum / numbers.Length;

            // === Шаг 7. Количество чисел, больших среднего ===
            int aboveAverage = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > average)
                {
                    aboveAverage++;
                }
            }
            // Формат "F1" — одна цифра после запятой, как в примере (46.7)
            Console.WriteLine($"Больше среднего ({average:F1}): {aboveAverage}");

            // Чтобы окно не закрылось сразу (нужно только если запускаешь двойным кликом)
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}