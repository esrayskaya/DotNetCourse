using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task3
{
    /*class MyArray
    {
        
        public MyArray()
        {
            
        }
        
        
       

    }*/
    class Program
    {
        public delegate void SortDelegate(string[] words);
        public static void Sorting(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i].Length < words[j].Length)
                    {
                        string[] help = new string[words.Length];
                        help[i] = words[j];
                        words[j] = words[i];
                        words[i] = help[i];
                    }
                }
            }
            List<int> counter = new List<int>();
            List<string> list = new List<string>();
            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i] == words[i + 1])
                {
                    list.Add(words[i]);
                    list.Add(words[i + 1]);
                    int index = 0;
                    foreach (int element in counter)
                    {
                        Array.Sort(list.ToArray(), index, element);
                        index += element;
                    }
                }
            }
        }
        public static void StartSortInThread(string[] arr)
        {
            SortDelegate del = new SortDelegate(Sorting);
            del?.Invoke(arr);

            Thread t = new Thread(delegate () { Sorting(arr); });
            t.Start();
            Thread.Sleep(500);

        }
        static void OutputOfArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            string[] arr = new string[4];
            arr[0] = "s";
            arr[1] = "da";
            arr[2] = "ab";
            arr[3] = "yyyy";
            Console.WriteLine("Массив до сортировки:");
            OutputOfArray(arr);
            StartSortInThread(arr);
            Console.WriteLine("Массив после сортировки:");
            OutputOfArray(arr);
            Console.ReadKey();
        }
    }
}
