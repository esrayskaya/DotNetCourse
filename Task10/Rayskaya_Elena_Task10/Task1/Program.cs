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
        public delegate int CompareDelegate(string str1, string str2);
        public static int Compare(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return 1;
            }
            else if (str1.Length > str2.Length)
            {
                return 2;
            }
            else
            {
                return 3;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую строку: ");
            string str = Console.ReadLine();
            string[] words = str.Split(new char[] { ' ' });
            CompareDelegate func1 = new CompareDelegate(Compare);
            //CompareDelegate funct1 = new CompareDelegate(SortingAlphavit);//создание делегата и передача функции сортировки в качестве параметра
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    int number = func1(words[i], words[j]);
                    if (number == 1)
                    {
                        string[] help = new string[words.Length];
                        help[i] = words[j];
                        words[j] = words[i];
                        words[i] = help[i];
                    }
                }
            }
            List<int> counter = new List<int>();
            int count = 1;
            List<string> list = new List<string>(); 
            for(int i=0; i < words.Length-1; i++)
            {
                if(func1(words[i], words[i + 1]) == 2)
                {
                    //count++;
                    list.Add(words[i]);
                    list.Add(words[i + 1]);
                    int index = 0;
                    foreach (int element in counter)
                    {
                        Array.Sort(list.ToArray(), index, element);
                        index += element;
                    }
                }
                /*else if(func1(words[i], words[i + 1]) == 3)
                {
                    counter.Add(count);
                    count = 1;
                }*/
            }
            /*int index = 0;
            foreach (int element in counter)
            {
                Array.Sort(words, index, element);
                index += element;
            }*/
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            Console.ReadLine();
        }
    }
}
