/*
Задание:
Напишите программу, которая получает на вход три числа, определяет наибольшее из них и выводит его. 
Если какую-либо из строк не удалось преобразовать в число, то вывести сообщение - "Ошибка!".
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        var isNumber1 = int.TryParse(Console.ReadLine(), out int number1);
        var isNumber2 = int.TryParse(Console.ReadLine(), out int number2);
        var isNumber3 = int.TryParse(Console.ReadLine(), out int number3);

        if (!isNumber1 || !isNumber2 || !isNumber3)
        {
            Console.WriteLine("Ошибка!");
        }
        else
        {
            int max = number1;
            
            if (number2 > max)
                max = number2;
            
            if (number3 > max)
                max = number3;
            
            Console.WriteLine(max);
        }
    }
}
