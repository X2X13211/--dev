/*
Задание:
В приведенной ниже программе выделены два пространства имен, в первом объявлен класс PersonA, 
во втором - PersonB. Укажите имена у пространств имен таким образом, чтобы приведенный код выполнялся.
*/

using System;
using A.B;
using A.C;

class Program
{
    static void Main(string[] args)
    {
        var nameA = Console.ReadLine();
        var nameB = Console.ReadLine();

        var pa = new PersonA() { Name = nameA };
        var pb = new PersonB() { Name = nameB };

        Console.WriteLine(pa.Name);
        Console.WriteLine(pb.Name);
    }
}

namespace A.B
{
    class PersonA 
    { 
        public string Name { get; set; } 
    }
}

namespace A.C
{
    class PersonB 
    { 
        public string Name { get; set; } 
    }
}
