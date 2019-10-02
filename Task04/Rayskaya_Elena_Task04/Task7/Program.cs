using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*^(([0-1][0-9]|2[0-3]):[0-5][0-9])?*/
            /*^(?:[01]?[0-9]|2[0-3]):[0-5][0-9]$*/
            Console.Write("Введите строку: ");
            string text = Console.ReadLine();
            int numberOfTimeRepeats = 0;
            Regex regexTime = new Regex("(([0-1][0-9]|2[0-3]):[0-5][0-9])");
            if (regexTime.IsMatch(text) == true)
            {
                //Console.WriteLine("оп оп");
                //numberOfTimeRepeats
                numberOfTimeRepeats = Regex.Matches(text, "(([0-1][0-9]|2[0-3]):[0-5][0-9])").Count;
            }
            Console.Write("Количество повторов времени в строке: " + numberOfTimeRepeats);
            Console.ReadLine();
        }
    }
}
