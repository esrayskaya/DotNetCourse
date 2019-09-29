using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int area;
            Console.WriteLine("Введите значения сторон прямоугольника");
            Console.Write("Введите значение стороны а: ");
            int sideA;
            //if (int.TryParse(stA, out SideA) == false) {  }
            while (!int.TryParse(Console.ReadLine(), out sideA))
            {
                Console.Write("Введите значение стороны а: ");
            }

            Console.Write("Введите значение стороны b: ");
            int sideB;
            //if (int.TryParse(stB, out SideB) == false) { }
            while (!int.TryParse(Console.ReadLine(), out sideB))
            {
                Console.Write("Введите значение стороны b: ");
            }

            if ((sideA <= 0) || (sideB <= 0) || (sideA >= 300) || (sideB >= 300))
            {
                Console.WriteLine("Введено неверное значение!");
            }
            else
            {
                area = sideA * sideB;
                Console.WriteLine("Площадь треугольника S равна: " + area);
            }

            Console.ReadLine();
        }
    }
}
