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
        static int FindMinElementOfArray(ref int[] a)
        {
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }
        static int FindMaxElementOfArray(ref int[] a)
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }
        static void OneDimentionalArraySort(ref int[] a)
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
            Class1.OneDimentionalArrayFilling(ref arr);
            Console.Write("Исходный массив: ");
            Class1.OneDimentionalArrayOutput(ref arr);
            Console.WriteLine();
            Console.WriteLine("Минимальный элемент массива: " + FindMinElementOfArray(ref arr));
            Console.WriteLine("Максимальный элемент массива: " + FindMaxElementOfArray(ref arr));
            Console.Write("Отсортированный массив: ");
            OneDimentionalArraySort(ref arr);
            Class1.OneDimentionalArrayOutput(ref arr);
            Console.ReadLine();
        }
    }
}
