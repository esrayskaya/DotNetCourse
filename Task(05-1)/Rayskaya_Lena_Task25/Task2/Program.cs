using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Round
    {
        private int x;
        private int y;
        private int r;
        
        private double areaOfACircle;
        public int X { get; set; }
        public int Y { get; set; }
        public int R
        {
            get
            {
                return r;
            }
            set
            {
                if (value >= 0)
                {
                    r = value;
                }
            }
        }
        public double Circumference
        {
            get
            {
                return 2 * Math.PI * R;
            }
        }
        public double AreaOfACircle
        {
            get
            {
                return Math.PI * Math.Pow(R, 2);
            }
        }
        public Round(int x, int y, int r) { X = x; Y = y; R = r; }
        public void GetInfo()
        {
            Console.WriteLine($"Центр окружности в точке ({X},{Y}) и радиусом {R} имеет:");
            Console.WriteLine("Длину окружности: " + String.Format("{0:0.000}", Circumference));
            Console.WriteLine("Площадь окружности: " + String.Format("{0:0.000}", AreaOfACircle));
        }
    }
    class Program
    {
        static int InputCoordinate(string str)
        {
            Console.Write("Введите " + str);
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Введен символ!");
                Console.Write("Введите " + str);
            }
            return number;
        }
        static int InputRadius(string str)
        {
            Console.Write("Введите " + str);
            int number;
            while( (!int.TryParse(Console.ReadLine(), out number)) || (number <= 0))
            {
                Console.WriteLine("Радиус не может быть отрицательным или равным нулю!");
                Console.Write("Введите радиус: ");
            }
            return number;
        }
        
        static void Main(string[] args)
        {
            //Round circle = new Round(CheckOfCoordinateValue("координату х: "), CheckOfCoordinateValue("координату y: "), CheckOfRadiusValue("радиус: "));
            /*Console.Write("Введите координату х: ");
            int x = CheckOfCoordinateValue("Введите координату х: ");
            Console.Write("Введите координату y: ");
            int y = CheckOfCoordinateValue("Введите координату у: ");
            Console.Write("Введите радиус: ");
            int r = CheckOfRadiusValue("Введите радиус: ");
            Round circle = new Round(x, y, r);*/
            Round circle = new Round(InputCoordinate("координату х: "),
                                     InputCoordinate("координату у: "),
                                     InputRadius("радиус: "));
            circle.GetInfo();
            Console.ReadLine();
        }
    }
}
