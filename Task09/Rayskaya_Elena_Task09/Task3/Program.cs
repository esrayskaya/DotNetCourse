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
            string str = "one, two! three! four? five one";
            Console.WriteLine(str);
            //string regex = "\\W + ";
            //string regex = "(?<=[ \\n])";
            List<string> list = new List<string>();
            string[] split = Regex.Split(str, @"[ ,\.;!?]");
            foreach (string s in split)
            {
                //Console.WriteLine(s);
                list.Add(s);
            }
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] == "")
                {
                    list.RemoveAt(i);
                }
            }
            bool check = false;
            int frequence = 1;
            List<string> listFrequense = new List<string>();
            int[] a = new int[list.Count];
            for(int i = 0; i < list.Count; i++)
            {
                
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        list.RemoveAt(j);
                        frequence++;
                        check = true;
                    }
                    else
                    {
                        frequence = 1;
                    }
                }
                if (check)
                {
                    list.RemoveAt(i);
                    //frequence++;
                    check = false;
                    //listFrequense.Add(frequence.ToString());
                }
                //listFrequense.Add(frequence.ToString());
                //a[i] = frequence;
                Console.WriteLine($"Слово {i+1} встретилось {frequence} раз");
            }
            listFrequense.Add(a.ToString());
            foreach (string element in listFrequense)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }
    }
}
