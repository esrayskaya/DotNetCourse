using System;
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
                    flag = false;
                }
                list = new List<T>(listT) as ICollection<T>;
            }
            return listT[0];
        }
        static void Main(string[] args)
        {
            List<int> listOfNumber = new List<int>(7) { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Элементы до удаления:");
            foreach(int element in listOfNumber)
            {
                Console.WriteLine(element);
            }
            int i1 = 1;
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
            }
            //List<T> col =new List<T>() { 1,2,3,4,5}
            //Console.WriteLine(RemoveEachSecondItem(listOfNumber));
            Console.WriteLine("Элементы до удаления:");
            int[] number = { 1, 2, 3, 4, 5, 6, 7 };
            LinkedList<int> linkedListOfNumber = new LinkedList<int>(number);
            foreach(int element in linkedListOfNumber)
            {
                Console.WriteLine(element.ToString());
            }
            Console.ReadLine();
        }
    }
}
