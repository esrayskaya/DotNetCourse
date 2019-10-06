using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        class Round
        {
            private int _x;
            private int _y;
            private int _r;
            public int X
            {
                get { return _x; }
                set { _x = value; }
            }
            public int Y
            {
                get { return _y; }
                set { _y = value; }
            }
            public int R
            {
                get { return _r; }
                set { _r = value; }
            }
            public double Circumference()
            {
                return Math.PI * (_r + _r);
            }
            public double AreaOfACircle()
            {
                return Math.PI * Math.Pow(_r, 2);
            }
            public Round(int intx, int inty, int intr) { X = intx; Y = inty; R = intr; }
            public Round() { _x = 0; _y = 0; _r = 1; }
            public void OutputInfo()
            {
                Console.WriteLine($"Координата х= {X}, Координата у= {Y}, Радиус= {R}");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите координату x= ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите координату y= ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Введите радиус r=");
            int r = int.Parse(Console.ReadLine());
            Round circle = new Round(x, y, r);
            circle.OutputInfo();
            Console.WriteLine("Площадь окружности=" + circle.AreaOfACircle());
            Console.WriteLine("Длина окружности=" + circle.Circumference());
            Console.WriteLine();

            Round circle2 = new Round();
            circle2.OutputInfo();
            Console.WriteLine("Площадь окружности=" + circle2.AreaOfACircle());

            Console.WriteLine("Длина окружности=" + circle2.Circumference());
            Console.ReadLine();
        }
    }
}
