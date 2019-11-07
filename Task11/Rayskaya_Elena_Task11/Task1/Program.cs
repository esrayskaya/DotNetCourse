using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"5! = {ClassMyMath.Factorial(5).ToString()}");
            Console.WriteLine($"14 в квадрате = {ClassMyMath.Pow(14, 2).ToString()}");
            Console.ReadKey();
        }
    }
}
