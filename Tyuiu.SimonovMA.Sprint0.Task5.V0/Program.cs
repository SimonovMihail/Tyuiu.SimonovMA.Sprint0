using System;
using Tyuiu.SimonovMA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.SimonovMA.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + b = " + DataService.Addition(1, 5));
            Console.WriteLine("A - b = " + DataService.Substraction(15, 5));
            Console.WriteLine("A * b = " + DataService.Multiplication(10, 10));
            Console.WriteLine("A / b = " + DataService.Division(5, 0));
            Console.ReadKey();
        }
    }
}
