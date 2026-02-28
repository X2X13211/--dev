/*
Задание:
Напишите программу, которая считывает массив чисел, разделенных пробелами, и выводит сумму и произведение переданных чисел через пробел.
*/

using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var nums = Console.ReadLine()
            .Split(" ")
            .Select(x => int.Parse(x.Trim()))
            .ToList();

        int sum = nums.Sum();
        int product = 1;

        foreach (int num in nums)
        {
            product *= num;
        }

        Console.WriteLine($"{sum} {product}");
    }
}
