using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        class Triangle
        {
            private int _a;
            private int _b;
            private int _c;
            public int A
            {
                get { return _a; }
                set { _a = value; }
            }
            public int B
            {
                get { return _b; }
                set { _b = value; }
            }
            public int C
            {
                get { return _c; }
                set { _c = value; }
            }
            public Triangle() { _a = 2; _b = 3;_c = 4; }
            public double GetSquare()
            {
                float P = _a + _b + _c;
                float P2 = P / 2;
                return Math.Sqrt(P2 * (P2 - _a) * (P2 - _b) * (P2 - _c));
            }
            public int GetPerimetr()
            {
                return _a + _b + _c;
            }
            public void OutputInfo()
            {
                Console.WriteLine($"Сторона А= {A}, Сторона В= {B}, Сторона С= {C}");
            }
        }
        static void Main(string[] args)
        {
            Triangle triangl = new Triangle();
            triangl.OutputInfo();
            Console.WriteLine("Периметр треугольника= " + triangl.GetPerimetr());
            //Console.WriteLine("Площадь треугольника= " + triangl.GetSquare());
            Console.Write("Площадь треугольника= "+(String.Format("{0:0.000}", triangl.GetSquare())));
            Console.ReadLine();
        }
    }
}
