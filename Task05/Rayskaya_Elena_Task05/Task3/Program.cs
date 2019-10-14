using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
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
        public Triangle() { A = 2; B = 3; C = 4; }
        public double GetSquare()
        {
            float P = A + B + C;
            float P2 = P / 2;
            return Math.Sqrt(P2 * (P2 - A) * (P2 - B) * (P2 - C));
        }
        public int GetPerimetr()
        {
            return A + B + C;
        }
        public void OutputInfo()
        {
            Console.WriteLine($"Сторона А= {A}, Сторона В= {B}, Сторона С= {C}");
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Triangle triangl = new Triangle();
            triangl.OutputInfo();
            Console.WriteLine("Периметр треугольника= " + triangl.GetPerimetr());
            //Console.WriteLine("Площадь треугольника= " + triangl.GetSquare());
            Console.Write("Площадь треугольника= " + (String.Format("{0:0.000}", triangl.GetSquare())));
            Console.ReadLine();
        }
    }
}
