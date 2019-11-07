using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class ClassMyMath
    {
        public static int Factorial(int number)
        {
            int result = 1;
            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }
            }
            else if (number == 0)
            {
                result = 1;
            }
            else { throw new Exception("Неверное значение (число должно быть > или = 0)"); }
            return result;
        }
        public static double Pow(int number, int degree)
        {
            int result = 1;
            for(int i = 0; i < degree; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
