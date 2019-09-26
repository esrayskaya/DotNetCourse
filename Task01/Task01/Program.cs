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
            int Area;
            bool flag=false;
            Console.WriteLine("Введите значения сторон прямоугольника");
            //while (flag == false)
            //{
                Console.Write("Введите значение стороны а: ");
                string stA = Console.ReadLine();
                int SideA;
                if (int.TryParse(stA, out SideA) == false)
                {
                    flag = false;
                }

                Console.Write("Введите значение стороны b: ");
                //int SideB = int.Parse(Console.ReadLine());
                string stB = Console.ReadLine();
                int SideB;
                if (int.TryParse(stB, out SideB) == false)
                {
                    flag = false;
                }
            //}
            if (flag==false)
            { }

           else if ((SideA <= 0) || (SideB <= 0))
            {
                Console.WriteLine("Введено неверное значение!");
            }
            else
            {
                Area = SideA * SideB;
                Console.WriteLine("Площадь треугольника S равна: " + Area);
            }

            Console.ReadLine();
        }
    }
}
