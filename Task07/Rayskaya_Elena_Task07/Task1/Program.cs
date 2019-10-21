using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class Figure
    {
        protected int x0;
        protected int y0;
        protected List<int> arrayOfPoints = new List<int>();
        public int X0
        {
            get { return x0; }
            set { x0 = value; }
        }
        public int Y0
        {
            get { return y0; }
            set { y0 = value; }
        }
        public Figure(int cenX, int cenY)
        { X0 = cenX; Y0 = cenY; }
        public string GetInfo()
        {
            return $"Начальные координаты ({X0},{Y0})";
        }
        public abstract string Draw();
    }
    class Line : Figure
    {
        protected int x1;
        protected int y1;
        public int X1
        {
            get { return x1; }
            set { x1 = value; }
        }
        public int Y1
        {
            get { return y1; }
            set { y1 = value; }
        }
        public Line(int cenX0, int cenY0, int cenX1, int cenY1) : base(cenX0, cenY0)
        {
            X1 = cenX1;
            Y1 = cenY1;
            arrayOfPoints.AddRange(new int[] { cenX1, cenY1 });
        }
        public override string Draw()
        {
            return GetInfo() + $"Конечные координаты {X1}{Y1}";
        }
    }
    class Round : Figure
    {
        protected double externalROfRound;
        public double ExternalROfRound
        {
            get
            {
                return externalROfRound;
            }
            set
            {
                if (value >= 0)
                {
                    externalROfRound = value;
                }
            }
        }
        public double GetPerimetrOfRound()
        {
            return 2 * Math.PI * ExternalROfRound;
        }
        public Round(int cenX0, int cenY0, double r) : base(cenX0, cenY0)
        {
            if (r <= 0)
            {
                throw new Exception("Радиус не может быть меньше или равен нулю!");
            }
            ExternalROfRound = r;
        }
        public override string Draw()
        {
            return GetInfo() + $"Радиус окружности: {ExternalROfRound}" +
                $"Периметр окружности: " + String.Format("{0:0.000}", GetPerimetrOfRound());
        }
    }
    class Rectangle: Figure
    {
        protected int x1;
        protected int y1;
        public int X1
        {
            get { return x1; }
            set { x1 = value; }
        }
        public int Y1
        {
            get { return y1; }
            set { y1 = value; }
        }
        public Rectangle(int cenX0, int cenY0, int cenX1, int cenY1) : base(cenX0, cenY0)
        {
            X1 = cenX1;
            Y1 = cenY1;
            arrayOfPoints.AddRange(new int[] { cenX1, cenY1 });
        }
        public int GetLengthSideA()
        {
            return Math.Abs(X1 - X0);
        }
        public int GetLengthSideB()
        {
            return Math.Abs(Y1 - Y0);
        }
        public double GetSquareOfTriangle()
        {
            return GetLengthSideA() * GetLengthSideB();
        }
        public double GetPerimetrOfTriangle()
        {
            return 2 * (GetLengthSideA() + GetLengthSideB());
        }
        public override string Draw()
        {
            return GetInfo() + $"Конечные координаты ({X1},{Y1})" +
                $"\nПлощадь прямоугольника: {String.Format("{0:0.000}", GetSquareOfTriangle())}" +
                $"\nПериметр прямоугольника: {String.Format("{0:0.000}", GetPerimetrOfTriangle())}";
        }
    }
    class Circle : Figure
    {
        protected int externalROfCircle;
        public int ExternalROfCircle
        {
            get
            {
                return externalROfCircle;
            }
            set
            {
                if (value >= 0)
                {
                    externalROfCircle = value;
                }
            }
        }
        public double GetPerimetrOfCircle()
        {
            return 2 * Math.PI * ExternalROfCircle;
        }
        public double GetSquareOfCircle()
        {
            return Math.PI * Math.Pow(ExternalROfCircle, 2);
        }
        public Circle(int cenX0, int cenY0, int r) : base(cenX0, cenY0)
        {
            if (r <= 0)
            {
                throw new Exception("Радиус не может быть меньше или равен нулю!");
            }
            ExternalROfCircle = r;
            arrayOfPoints.AddRange(new int[] { r });
        }
        public override string Draw()
        {
            return GetInfo() + $"Радиус круга: {ExternalROfCircle}";
                
            
            /*Console.WriteLine("Площадь круга: " + String.Format("{0:0.000}", GetSquareOfCircle()));
            Console.WriteLine("Периметр круга: " + String.Format("{0:0.000}", GetPerimetrOfCircle()));*/
        }
    }
    class Ring : Circle
    {
        protected int innerROfCircle;
        public int InnerROfCircle
        {
            get { return innerROfCircle; }
            set
            {
                if (value >= 0)
                {
                    innerROfCircle = value;
                }
            }
        }
        public double GetSquareOfRing()
        {
            return GetSquareOfCircle() - Math.PI * Math.Pow(InnerROfCircle, 2);
        }
        public Ring(int cenX0, int cenY0, int r, int innerR) : base(cenX0, cenY0, r)
        {
            if ((innerR <= 0) || (r <= 0) || (innerR >= r))
            {
                throw new Exception("Неверное значение радиуса!");
            }
            InnerROfCircle = innerR;
            arrayOfPoints.AddRange(new int[] { innerR });
        }
        public override string Draw()
        {
            return GetInfo() + "\nПлощадь кольца: " + String.Format("{0:0.000}", GetSquareOfRing());
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
                Console.WriteLine("Неверное значение!");
                Console.Write("Введите " + str);
            }
            return number;
        }
        static void Main(string[] args)
        {
            //задать в массив лист с фигурами. вызывать Drow с этими координатами
            Console.WriteLine("Создание фигур: линия, окружность, прямоугольник, круг, кольцо");
            int point = 0, point1 = 1, radius = 5;
            List<Figure> figures = new List<Figure>();
            Line line = new Line(point, point1, point1, point);
            Rectangle rectangle = new Rectangle(point, point1, point1, point);
            Circle circle = new Circle(point, point, radius);
            Round round = new Round(point, point, radius);
            Ring ring = new Ring(point, point, radius, point1);
          
            Console.WriteLine(line.Draw());
            Console.WriteLine(rectangle.Draw());
            Console.WriteLine(circle.Draw());
            Console.WriteLine(round.Draw());
            Console.WriteLine(ring.Draw());
            Console.ReadLine();
        }
    }
}
