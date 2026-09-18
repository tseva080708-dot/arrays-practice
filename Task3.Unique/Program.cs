using System;

namespace Task3.Unique
{
    class Program
    {
        /// <summary>
        /// Возвращает массив уникальных элементов без LINQ и HashSet.
        /// </summary>
        public static int[] GetUnique(int[] source)
        {
            if (source == null || source.Length == 0)
                return new int[0];

            int[] result = new int[source.Length];
            int resultCount = 0;

            for (int i = 0; i < source.Length; i++)
            {
                bool alreadyExists = false;

                // Проверяем, был ли элемент ранее во вспомогательном массиве
                for (int j = 0; j < resultCount; j++)
                {
                    if (result[j] == source[i])
                    {
                        alreadyExists = true;
                        break;
                    }
                }

                // Если не было — добавляем
                if (!alreadyExists)
                {
                    result[resultCount] = source[i];
                    resultCount++;
                }
            }

            // Обрезаем до нужного размера
            int[] trimmed = new int[resultCount];
            for (int i = 0; i < resultCount; i++)
                trimmed[i] = result[i];

            return trimmed;
        }

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Тестовые данные из ТЗ
            int[] source = { 1, 2, 2, 3, 4, 4, 4, 5 };

            Console.WriteLine("Исходный:   " + string.Join(", ", source));

            int[] unique = GetUnique(source);
            Console.WriteLine("Уникальные: " + string.Join(", ", unique));

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}