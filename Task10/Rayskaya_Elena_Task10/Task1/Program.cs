using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public delegate char[] SortDelegate(char[] str);
        public static char[] SortingAlphavit(char[] str)
        {
            char help;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[j] > str[i])
                    {
                        help = str[j];
                        str[j] = str[i];
                        str[i] = help;
                    }
                }
            }
            return str;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую строку: ");
            string str = Console.ReadLine();
            string[] words = str.Split(new char[] { ' ' });
            SortDelegate funct1 = new SortDelegate(SortingAlphavit);//создание делегата и передача функции сортировки в качестве параметра
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i].Length < words[j].Length)
                    {
                        string help;
                        help = words[j];
                        words[j] = words[i];
                        words[i] = help;
                    }
                    if (words[i].Length == words[j].Length)
                    {
                        //вызов делегата
                        string a = funct1(words[i].ToCharArray()).ToString();
                        words[i] = a;
                    }
                }
            }
            for(int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            Console.ReadLine();
        }
    }
}
