using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "one, two! three! one! four? five";
            Console.WriteLine(str);
            //string regex = "\\W + ";
            //string regex = "(?<=[ \\n])";
            List<string> list = new List<string>();
            string[] split = Regex.Split(str, @"[ ,\.;!?]");
            foreach (string s in split)
            {
                list.Add(s);
            }
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] == "")
                {
                    list.RemoveAt(i);
                }
            }
            //int frequence = 1;
           // List<string> listFrequense = new List<string>();
            for(int i=0;i < list.Count; i++)
            {
                var count = list.Count(ch => ch == list[i]);
                Console.WriteLine($"Количество {list[i]} {count}");
            }
            /*for(int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        list.RemoveAt(j);
                        frequence++;
                    }
                    else
                    {
                        frequence = 1;
                    }
                }
                Console.WriteLine($"Слово {list[i]} встретилось {frequence} раз");
            }*/
            Console.ReadLine();
        }
    }
}
