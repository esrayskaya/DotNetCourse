using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        public delegate string SortDelegate(string str);
        public static string SortingAlphavit(string str)
        {
            //string st2 = string.Join("[a-z]", str);
            char[] result = str.ToCharArray();
            char[] help=new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (result[j] > result[i])
                    {
                        help[i] = result[j];
                        result[j] = result[i];
                        result[i] = help[i];
                    }
                }
            }
            string strEnd = result.ToString();
            //string[] stringInArray = strEnd.Split(new char[] { 'a', 'b', 'c', 'd', 'e' });
            return strEnd;
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
                        string[] help=new string[words.Length];
                        help[i] = words[j];
                        words[j] = words[i];
                        words[i] = help[i];
                    }
                    if (words[i].Length == words[j].Length)
                    {
                        //вызов делегата
                        //char[] b = words[i].ToCharArray();
                        var a = funct1(words[i]);
                        //words[i] = a.ToString();
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
