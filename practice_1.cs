using System;

class Practice1
{
    static void Main()
    {
        Console.Write("Input first number: ");
        int name1 = int.Parse(Console.ReadLine());
        Console.Write("Input second number: ");
        int name2 = int.Parse(Console.ReadLine());
        Console.Write("Input third number: ");
        int name3 = int.Parse(Console.ReadLine());
        Console.Write("Input fourth number: ");
        int name4 = int.Parse(Console.ReadLine());
        Console.Write("Input five number (x1): ");
        int name5 = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"You input nums: {name1}, {name2}, {name3}, {name4}, {name5}");
        double calculate_abs_number = (name1 + name2 + name3 + name4 + name5) / 5.0;
        Console.Write($"Response: {calculate_abs_number}\n");

        Console.Write("Input third number (x2): ");
        int name3_2 = int.Parse(Console.ReadLine());
        Console.Write("Input first number (y2): ");
        int name4_2 = int.Parse(Console.ReadLine());

        int result1 = Calculate1(name1, name2);
        int result2 = Calculate2(name3_2, name4_2);

        Console.Write($"Response: {result1} \n");
        Console.Write($"Response: {result2} \n");
    }

    static int Calculate1(int a, int b)
    {
        return a * b;
    }

    static int Calculate2(int c, int d)
    {
        return c * d;
    }
}
