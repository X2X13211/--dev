using System;

class Practice2
{
    static void Main()
    {
        Console.Write("Input x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Input y: ");
        int y = int.Parse(Console.ReadLine());
        Console.Write("Input z: ");
        int z = int.Parse(Console.ReadLine());
        
        if (x + y + z > x * y * z)
        {
            Console.WriteLine(x + y + z);
        }
        else if (x + y + z < x * y * z)
        {
            Console.WriteLine(x * y * z);
        }
        else if (((x + y + z) / 2) > (Math.Pow(x * y * z, 2) + 1))
        {
            Console.WriteLine(((x + y + z) / 2));
        }
        else if (((x + y + z) / 2) < (Math.Pow(x * y * z, 2) + 1))
        {
            Console.WriteLine((Math.Pow(x * y * z, 2) + 1));
        }
        else
        {
            Console.WriteLine("None");
        }

        Console.Write("Input x: ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Input z: ");
        z = int.Parse(Console.ReadLine());
        double y2 = 0;
        
        if (x < 10 | z > 5)
        {
            y2 = x + z;
            Console.WriteLine($"Respose: {y2}");
        }
        else
        {
            y2 = x * z;
            Console.WriteLine($"Respose: {y2}");
        }

        Console.WriteLine("Input you experiens of job: ");
        int sub = int.Parse(Console.ReadLine());
        int Money = 130;
        
        if (5 <= sub & sub <= 15)
        {
            Money += 180;
            Console.WriteLine($"Your money: {Money}");
        }
        else if (sub > 15)
        {
            for (int i = 0; i > sub; i++)
            {
                Money += 10;
                Console.WriteLine($"Response: {Money}");
            }
        }
        else if (sub < 5)
        {
            Console.WriteLine(Money);
        }
        else
        {
            Console.WriteLine("Вы уволены!");
        }

        Console.Write("Input a: ");
        int name1 = int.Parse(Console.ReadLine());
        Console.Write("Input b: ");
        int name2 = int.Parse(Console.ReadLine());
        name1 = name2;
        Console.WriteLine($"a = {name1}");
        ChangeValueRef(ref name2);
        Console.WriteLine($"a = {name2}");

        Console.Write("Input first number: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Input second number: ");
        int n = int.Parse(Console.ReadLine());
        
        if (m % n == 0 || n % m == 0)
        {
            Console.Write("1");
        }
        else
        {
            Random rand = new Random();
            int res = rand.Next(1, 20);
            Console.Write(res);
        }

        Console.Write("Input x: ");
        x = int.Parse(Console.ReadLine());
        Console.Write("Input y: ");
        y = int.Parse(Console.ReadLine());
        
        if (x < y)
        {
            double calculate = x - y;
            Console.WriteLine($"Response: {calculate}");
        }
        else
        {
            double z2 = y - x + 1;
            Console.WriteLine($"Response: {z2}");
        }
    }

    static void ChangeValueRef(ref int x)
    {
        x = 100;
    }
}
