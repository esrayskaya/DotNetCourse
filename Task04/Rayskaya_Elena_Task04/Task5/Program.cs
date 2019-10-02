using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {/*^ (([0 - 1][0 - 9] | 2[0 - 3]):[0-5] [0-9])$*/
            /*< (/?[^>] +) >*/
            Console.Write("Введите текст HTML: ");
            string text = Console.ReadLine();
            Regex myReg = new Regex("<(/?[^>]+)>");
            Console.WriteLine(myReg.IsMatch(text));// true
            text = myReg.Replace(text, "_");
          
            Console.WriteLine("Результат замены: "+ text);

            Console.ReadLine();
        }
    }
}
