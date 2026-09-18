using System;

// Вариант 0: Успеваемость студентов
// Номер в журнале: 21, 21 % 3 = 0
namespace Final.Task
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Данные из ТЗ
            string[] students = { "Анна", "Борис", "Виктор", "Галина" };
            int[] grades      = { 85, 92, 78, 95 };

            // === 1. Таблица «имя — баллы» с выравниванием ===
            Console.WriteLine("=== УСПЕВАЕМОСТЬ СТУДЕНТОВ ===");
            Console.WriteLine($"{"Имя",-10} | {"Баллы",5}");
            Console.WriteLine(new string('-', 20));
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"{students[i],-10} | {grades[i],5}");
            }

            // === 2. Лучший студент: Array.IndexOf + поиск Max ===
            int maxGrade = grades[0];
            for (int i = 1; i < grades.Length; i++)
            {
                if (grades[i] > maxGrade)
                    maxGrade = grades[i];
            }
            int bestIndex = Array.IndexOf(grades, maxGrade);
            Console.WriteLine($"\nЛучший студент: {students[bestIndex]} ({maxGrade} баллов)");

            // === 3. Средний балл группы ===
            int sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }
            double average = (double)sum / grades.Length;
            Console.WriteLine($"Средний балл группы: {average:F1}");

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
