using System;

using Tyuiu.SimonovMA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.SimonovMA.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Михаил"));
            Console.ReadKey();
        }
    }
}
