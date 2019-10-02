using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayLibrary;

namespace Task1
{
    class Program
    {
        static int FindMinElementOfArray(int[] a)
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }
        static int FindMaxElementOfArray(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }
        static void OneDimentionalArraySort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - 1; j++)
                {
                    if (a[j] < a[j + 1])
                    {
                        int z = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = z;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int n = 9;
            int[] arr = new int[n];
            Class1.OneDimentionalArrayFilling(arr);
            Console.Write("Исходный массив: ");
            Class1.OneDimentionalArrayOutput(arr);
            Console.WriteLine();
            Console.WriteLine("Минимальный элемент массива: " + FindMinElementOfArray(arr));
            Console.WriteLine("Максимальный элемент массива: " + FindMaxElementOfArray(arr));
            Console.Write("Отсортированный массив: ");
            OneDimentionalArraySort(arr);
            Class1.OneDimentionalArrayOutput(arr);
            Console.ReadLine();
        }
    }
}
