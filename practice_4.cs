using System;

class Practice4
{
    static void Main()
    {
        Console.WriteLine("=== Табуляция функции y = 2x + 1 ===\n");

        Console.WriteLine("а) Отрезок [0; 2.5], шаг 0.5 (по убыванию):");
        for (double x = 2.5; x >= 0; x -= 0.5)
        {
            x = Math.Round(x, 2);
            double y = 2 * x + 1;
            Console.WriteLine($"x = {x:F1}, y = {y:F2}");
        }

        Console.WriteLine("\nб) Введите a и b (a < b), шаг 1:");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Результат (по возрастанию):");
        for (double x = a; x <= b; x += 1)
        {
            double y = 2 * x + 1;
            Console.WriteLine($"x = {x:F1}, y = {y:F2}");
        }

        Console.WriteLine("\nв) Введите a, b и h (a < b, h > 0):");
        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        Console.Write("h = ");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("Результат (по возрастанию):");
        for (double x = a; x <= b; x += h)
        {
            double y = 2 * x + 1;
            Console.WriteLine($"x = {x:F3}, y = {y:F3}");
        }

        Console.WriteLine("=== Сравнение чисел с заданным значением A ===\n");
        Console.Write("Введите число A для сравнения: ");
        double A = double.Parse(Console.ReadLine());
        Console.Write("Введите количество чисел N: ");
        int N = int.Parse(Console.ReadLine());
        int count = 0;
        Console.WriteLine($"\nВведите {N} чисел для сравнения с {A}:");
        while (count < N)
        {
            count++;
            Console.Write($"Число {count}: ");
            double number = double.Parse(Console.ReadLine());
            
            string result = number > A ? "БОЛЬШЕ" : (number < A ? "МЕНЬШЕ" : "РАВНО");
            Console.WriteLine($" → Число {number} {result} {A}\n");
        }
        Console.WriteLine("Программа завершена.");
    }
}
