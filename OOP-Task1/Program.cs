using System;
using OOP_Task1.Core;

/*
 Описать класс «многочлен». Реализовать методы «произведение многочленов»,

«сравнение на равенство», чтение из файла и запись в файл. Протестировать

работоспособность каждого метода вашего класса.
*/

namespace OOP_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var multimonal = new Multimonal();
            multimonal.StartOperations();
            Console.ReadKey();
        }
    }
}
