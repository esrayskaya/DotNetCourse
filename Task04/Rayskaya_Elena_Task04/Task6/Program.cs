using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {/*^-?[0 - 9]{3,15}*/
            /*([A - z] +)*/
            /*^-?[0-9][0-9]?$*/
            Console.Write("Введите число: ");
            string text = Console.ReadLine();
            Regex regexScinceNumber = new Regex("^-?[0-9]*[.,]?[0-9]+(?:[e][-+]?[0-9]+)?$");
            Regex regexNumber = new Regex("^-?[0-9]*[.,]?[0-9]+$");
            if (regexNumber.IsMatch(text) == true)
            {
                Console.WriteLine("Это число в обычной нотации");
            }
            else if (regexScinceNumber.IsMatch(text) == true)
            {
                Console.WriteLine("Это число в научной нотации");
            }
            else Console.WriteLine("Это не число");
            
            Console.ReadLine();
        }
    }
}
