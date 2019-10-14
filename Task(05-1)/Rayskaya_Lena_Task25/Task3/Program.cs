using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Triangle
    {
        private double sideOne;
        private double sideTwo;
        private double sideThree;
        public double SideOne
        {
            get
            {
                return sideOne;
            }
            set
            {
                if (value >= 0)
                {
                    sideOne = value;
                }
            }
        }
        public double SideTwo
        {
            get
            {
                return sideTwo;
            }
            set
            {
                if (value >= 0)
                {
                    sideTwo = value;
                }
            }
        }
        public double SideThree
        {
            get
            {
                return sideThree;
            }
            set
            {
                if (value >= 0)
                {
                    sideThree = value;

                }
            }
        }
        public double GetSquare()
        {
            return Math.Sqrt(GetPerimetr() * (GetPerimetr() - SideOne) * (GetPerimetr() - SideTwo) * (GetPerimetr() - SideThree));
        }
        public double GetPerimetr()
        {
            return SideOne + SideTwo + SideThree;
        }
        public Triangle(double sOne, double sTwo, double sThree) { SideOne = sOne; SideTwo = sTwo; SideThree = sThree; }
        public void GetInfo()
        {
            Console.WriteLine("Сторона А: " + SideOne);
            Console.WriteLine("Сторона В: " + SideTwo);
            Console.WriteLine("Сторона С: " + SideThree);
        }
    }
    class Program
    {
        static bool CheckOfExistsOfTriangle(double sOne, double sTwo, double sThree)
        {
            if ((sOne + sTwo < sThree) || (sOne + sThree < sTwo) || (sTwo + sThree < sOne))
            {
                //Console.Write($"Треугольника со сторонами {sOne}, {sTwo} и {sThree} не существует");
                return false;
            }
            return true;
        }
        static double InputSide(string side)
        {
            Console.Write("Введите " + side);
            double number;
            while ((!double.TryParse(Console.ReadLine(), out number)) || (number <= 0))
            {
                Console.WriteLine("Сторона не может быть отрицательной или равной нулю!");
                Console.Write("Введите " + side);
            }
            return number;
        }
        static void Main(string[] args)
        {
            /*double sideA;
            double sideB;
            double sideC;*/
            double sideA = InputSide("значение стороны А: ");
            double sideB = InputSide("значение стороны B: ");
            double sideC = InputSide("значение стороны C: ");
            while (CheckOfExistsOfTriangle(sideA, sideB, sideC) == false)
            {
                Console.WriteLine($"Треугольника со сторонами {sideA}, {sideB} и {sideC} не существует");
                sideA = InputSide("значение стороны А: ");
                sideB = InputSide("значение стороны B: ");
                sideC = InputSide("значение стороны C: ");
            }
            Triangle triangle1 = new Triangle(sideA, sideB, sideC);
            triangle1.GetInfo();
            Console.WriteLine("Площадь треугольника АBC: " + String.Format("{0:0.000}", triangle1.GetSquare()));
            Console.WriteLine("Периметр треугольника ABC: " + String.Format("{0:0.000}", triangle1.GetPerimetr()));

            Console.ReadLine();
        }
    }
}
