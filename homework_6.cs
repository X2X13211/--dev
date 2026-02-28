/*
Задание:
Напишите программу, которая считывает массив чисел, разделенных пробелами (каждое из чисел может находиться в диапазоне от 1 до 5) и выводит их текстовое представление в соответствии со следующими правилами:
    числу 1 соответствует "One";
    числу 2 соответствует "Two";
    числу 3 соответствует "Three";
    числу 4 соответствует "Four";
    числу 5 соответствует "Five";
Например, если на вход получена следующая последовательность:
1 2 3 5
Нужно вывести:
One Two Three Five
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

        var result = nums.Select(x => x switch
        {
            1 => "One",
            2 => "Two",
            3 => "Three",
            4 => "Four",
            5 => "Five",
            _ => throw new ArgumentOutOfRangeException()
        });

        Console.WriteLine(string.Join(" ", result));
    }
}
