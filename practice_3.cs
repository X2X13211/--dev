using System;

class Practice3
{
    static void Main()
    {
        Console.WriteLine("Input size: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        int sum = 1;
        
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Input array: ");
            array[i] = int.Parse(Console.ReadLine());
            if (array[i] % 2 == 0)
            {
                sum *= array[i];
            }
            Console.WriteLine($"Response element : {sum}");
        }
        
        foreach (int num in array)
        {
            Console.WriteLine($"Response elements in array: {num}");
        }

        Console.WriteLine("Input size: ");
        size = int.Parse(Console.ReadLine());
        array = new int[size];
        int sum2 = 0;
        
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Input array: ");
            array[i] = int.Parse(Console.ReadLine());
            if (array[i] % 2 != 0)
            {
                sum2 += array[i];
            }
            Console.WriteLine($"Response element : {sum2}");
        }
        
        foreach (int num in array)
        {
            Console.WriteLine($"Response elements in array: {num}");
        }

        Console.WriteLine("input size: ");
        size = int.Parse(Console.ReadLine());
        array = new int[size];
        
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("input element of array: ");
            array[i] = int.Parse(Console.ReadLine());
            Console.WriteLine($"{i} Elements of array: {array[i]}");
            
            if (i > 0 && array[0] < array[i])
            {
                Console.WriteLine($"High element of array: {array[i]}");
            }
        }

        Console.WriteLine("input size: ");
        size = int.Parse(Console.ReadLine());
        array = new int[size];
        
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("input element of array: ");
            array[i] = int.Parse(Console.ReadLine());
            Console.WriteLine($"{i} Elements of array: {array[i]}");
            
            if (i > 0 && array[0] < array[i])
            {
                Console.WriteLine($"High element of array: {array[i]}");
            }
        }

        Console.WriteLine("input size: ");
        size = int.Parse(Console.ReadLine());
        array = new int[size];
        int sum3 = 0;
        
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Input elements of array: ");
            array[i] = int.Parse(Console.ReadLine());
            Console.WriteLine($"{i} Elements of array {array[i]}");
        }
        
        if (array.Length > 1) 
        {
            int first_element = array[1];
            for (int j = first_element; j < array[^1]; j++)
            {
                sum3 += j;
            }
            Console.WriteLine($"quantity elements of array = {sum3}");
        }

        Console.WriteLine("input size: ");
        size = int.Parse(Console.ReadLine());
        array = new int[size];
        int sum4 = 0;
        Console.WriteLine("Iput C: ");
        int C = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Input elements of array: ");
            array[i] = int.Parse(Console.ReadLine());
            Console.WriteLine($"{i} Elements of array {array[i]}");
            if (array[i] > C)
            {
                sum4 += array[i];
            }
        }
        Console.WriteLine($"Sum elements more than C: {sum4}");

        Console.WriteLine("input size: ");
        size = int.Parse(Console.ReadLine());
        array = new int[size];
        int sum5 = 0;
        Console.WriteLine("Iput C: ");
        C = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Input elements of array: ");
            array[i] = int.Parse(Console.ReadLine());
            Console.WriteLine($"{i} Elements of array {array[i]}");
            if (array[i] < C)
            {
                sum5 += array[i];
            }
        }
        Console.WriteLine($"Sum elements more than C: {sum5}");
    }
}
