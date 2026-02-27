using System;

class Practice5
{
    static void Main()
    {
        Console.WriteLine("=== Формирование матрицы m×n ===\n");
        Console.WriteLine("Условие: элементы i-й строки равны 10i\n");
        
        Console.Write("Введите количество строк m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов n: ");
        int n = int.Parse(Console.ReadLine());

        int[][] matrix = new int[m][];

        for (int i = 0; i < m; i++)
        {
            matrix[i] = new int[n];
            int value = 10 * (i + 1); 
            for (int j = 0; j < n; j++)
            {
                matrix[i][j] = value;
            }
        }

        Console.WriteLine("\nСформированная матрица:");
        for (int i = 0; i < m; i++)
        {
            Console.Write($"Строка {i + 1,2}: ");
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{matrix[i][j],4} ");
            }
            Console.WriteLine();
        }
    }
}
