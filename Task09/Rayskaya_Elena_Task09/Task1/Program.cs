﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static T RemoveEachSecondItem<T>(ICollection<T> list)
        {
            List<T> listT = new List<T>();
            bool flag=true;
            while (list.Count != 1)
            {
                listT.Clear();
                foreach(T element in list)
                {
                    if (flag == true)
                    {
                        listT.Add(element);
                    }
                    flag = !flag;
                }
                list = new List<T>(listT) as ICollection<T>;
            }
            return listT[0];
        }
        static void Main(string[] args)
        {
            List<int> listOfNumber = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            LinkedList<int> linkedListOfNumber = new LinkedList<int>(listOfNumber);
            Console.WriteLine("Элементы до удаления:");
            foreach(int element in listOfNumber)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("После: " + RemoveEachSecondItem(listOfNumber).ToString());
            Console.WriteLine("Элементы до удаления:");

            foreach (int element in linkedListOfNumber)
            {
                Console.WriteLine(element.ToString());
            }
            Console.WriteLine("После: " + RemoveEachSecondItem(linkedListOfNumber).ToString());
            /*int i1 = 1;
            int firstCount = listOfNumber.Count;
            while (listOfNumber.Count != 1)
            {
                if (i1 < listOfNumber.Count)
                {
                    int a = listOfNumber[i1];
                    listOfNumber.RemoveAt(i1);
                    i1++;
                }
                else if (i1 >= listOfNumber.Count)
                {
                    i1 = 0;
                    if (i1 < listOfNumber.Count)
                    {
                        int a = listOfNumber[i1];
                        if (firstCount % 2 != 0)
                        {
                            listOfNumber.RemoveAt(i1);
                            i1++;
                            i1 = 1;
                        }
                        else
                        {
                            listOfNumber.RemoveAt(i1 + 1);
                            i1++;
                            i1 = 0;
                        }
                    }
                }
            }
            Console.WriteLine("Оставшийся элемент:");
            foreach(int element in listOfNumber)
            {
                Console.WriteLine(element);
            }*/

            Console.ReadLine();
        }
    }
}
