using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Round
    {
        protected int x;
        protected int y;
        protected int externalR;
        public int X { get; set; }
        public int Y { get; set; }
        public int ExternalR
        {
            get
            {
                return externalR;
            }
            set
            {
                if (value >= 0)
                {
                    externalR = value;
                }
            }
        }
        public double CircumferenceExternal
        {
            get
            {
                return 2 * Math.PI * ExternalR;
            }
        }
        public double AreaOfACircleExternal
        {
            get
            {
                return Math.PI * Math.Pow(ExternalR, 2);
            }
        }
        public Round(int x, int y, int r) 
        { X = x; Y = y; ExternalR = r; }
        public void GetInfo()
        {
            Console.WriteLine($"Центр окружности в точке ({X},{Y}) и внешним радиусом {ExternalR} имеет:");
            //Console.WriteLine("Длину окружности: " + String.Format("{0:0.000}", CircumferenceExternal));
            //Console.WriteLine("Площадь окружности: " + String.Format("{0:0.000}", AreaOfACircleExternal));
        }
    }
    class Ring : Round
    {
        protected double innerR;
        protected double areaOfRing;
        public double InnerR
        {
            get
            {
                return innerR;
            }
            set
            {
                //CheckOfExistRing()
                if (value >= 0)
                {
                    innerR = value;
                }
            }
        }
        public double AreaOfRing
        {
            get
            {
                return AreaOfACircleExternal - (Math.PI * Math.Pow(InnerR, 2));
            }
        }
        public Ring(int x, int y, int r, double ir) : base(x, y, r)
        {
            if ((ir >= r)|| (ir<=0) || (r<=0))
            {
                throw new Exception("Неверное значение радиуса!");
               // Console.WriteLine()
            }
            else InnerR = ir;
        }
        public void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Внутренний радиус: " + InnerR);
            Console.WriteLine("Площадь кольца: "+ String.Format("{0:0.000}", AreaOfRing));
        }
        public bool CheckOfExistRing(double radiusCircle, double radiusInner)
        {
            if (radiusCircle <= radiusInner)
            {
                return false;
            }
            else return true;
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
        static int InputRadius(string str)
        {
            Console.Write("Введите " + str);
            int number;
            while ((!int.TryParse(Console.ReadLine(), out number))/* || (number <= 0)*/)
            {
                Console.WriteLine("Неверное значение!");
                Console.Write("Введите радиус: ");
            }
            return number;
        }
        static void Main(string[] args)
        {
            try
            {
                Ring ring1 = new Ring(InputCoordinate("координату х: "),
                                         InputCoordinate("координату у: "),
                                         InputRadius("внешний радиус: "),
                                         InputRadius("внутренний радиус: "));
                ring1.GetInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        } 
    }
}
