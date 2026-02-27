/*
Задание:
Напишите реализацию метода GetPersonAge. Метод должен работать следующим образом:
- Если у объекта person, поле Age не равно null, то вернуть его (поля Age) значение.
- Если у объекта person, поле Age равно null, то вернуть -1.
*/

using System;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        var json = Console.ReadLine();
        var person = JsonSerializer.Deserialize<Person>(json);

        Console.WriteLine(GetPersonAge(person));
    }

    static int GetPersonAge(Person person)
    {
        if (person.Age != null) 
        {
            return person.Age.Value;
        } 
        else 
        {
            return -1;
        }
    }
}

class Person
{
    public string Name { get; set; } = string.Empty;
    public int? Age { get; set; }
}
