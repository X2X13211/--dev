/*
Задание:
Напишите реализацию метода AdditionOrMultiplication, который:
    Если параметр flag == null, то складывает num1 и num2 и возвращает полученную сумму.
    Если параметр flag != null, то умножает num1 и num2 и возвращает полученное произведение.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        var number1 = int.Parse(Console.ReadLine());
        var number2 = int.Parse(Console.ReadLine());
        bool? flag = Console.ReadLine() == "null" ? null : true;

        var result = AdditionOrMultiplication(number1, number2, flag);
        Console.WriteLine(result);
    }

    static int AdditionOrMultiplication(int num1, int num2, bool? flag)
    {
        if(flag == null) {
            int num = num1 + num2; 
            return num;
        }
        else {
            int num = num1 * num2; 
            return num; 
        }
    }
}
