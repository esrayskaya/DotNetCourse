using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
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
            return Math.PI * (R + R);
        }
        public double AreaOfACircle()
        {
            return Math.PI * Math.Pow(R, 2);
        }
        public Round(int intx, int inty, int intr)
        {
            X = intx; Y = inty;
            if (intr <= 0)
            {
                Console.WriteLine("R=1");
                R = 1;
            }
            else R = intr;
        }
        public Round() { X = 0; Y = 0; R = 1; }
        public void OutputInfo()
        {
            Console.WriteLine($"Координата х= {X}, Координата у= {Y}, Радиус= {R}");
        }
    }
    class Program
    {
        
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
            Console.WriteLine("Площадь окружности: ");
            Console.WriteLine(String.Format("{0:0.000}", circle.AreaOfACircle()));
            Console.WriteLine("Длина окружности: ");
            Console.WriteLine(String.Format("{0:0.000}", circle.Circumference()));
            Console.WriteLine();

            Round circle2 = new Round();
            circle2.OutputInfo();
            Console.WriteLine("Площадь окружности: ");
            Console.WriteLine(String.Format("{0:0.000}", circle2.AreaOfACircle()));
            Console.WriteLine("Длина окружности: ");
            Console.WriteLine(String.Format("{0:0.000}", circle2.Circumference()));
            Console.ReadLine();
        }
    }
}
