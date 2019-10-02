using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();

            int kol = 0;
            /*int kolsymbol;*/
            var charsToRemove = new string[] { "!", ",", ".", ";", "'", "?" };
            foreach (var c in charsToRemove)
            {
                str = str.Replace(c, string.Empty);
            }
            //Console.Write(str);
            /* char[] ch = str.ToCharArray();
             for (int i = 0; i < ch.Length; i++)
             {
                 if (ch[i] == ' ')
                 {
                     kol++;
                 }
             }
             kolsymbol = str.Length - kol;
             Double s = kolsymbol / (kol + 1);
             Console.WriteLine("Кол-во пробелов равно " + kol);
             Console.WriteLine("Кол-во символов без пробелов " + kolsymbol);*/
            string strWithProbel = " ";
            //int countOfSymbol = str.Length;
            for (int i=0; i < str.Length; i++)
            {
                if (strWithProbel.Contains(str[i]))
                {
                    kol++;
                }
                //Console.WriteLine(kol);
            }
            int countOfSymbol = str.Length - kol;
            Console.WriteLine("Количество символов без пробелов= " + countOfSymbol);
            int countOfWords = kol + 1;
            Console.WriteLine("Количество слов в строке= " + countOfWords);
            float awerageWordLength = countOfSymbol / countOfWords;
            Console.WriteLine("Средняя дина строки " + awerageWordLength);
            Console.ReadLine();
        }
    }
}
