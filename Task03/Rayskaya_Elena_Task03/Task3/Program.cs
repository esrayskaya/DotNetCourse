using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayLibrary;

namespace Task3
{
    class Program
    {
        /*static void OneDimentionalArrayFilling(ref int[] a)
        {
            Random rand = new Random();
            for (int i = 0; i < 9; i++)
            {
                a[i] = rand.Next(-50, 50);
            }
        }*/
        static int OneDimentionalArraySumOfElements(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    sum += a[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int n = 9;
            int[] arr = new int[n];
            Class1.OneDimentionalArrayFilling(arr);
            Console.WriteLine("Одномерный массив:");
            Class1.OneDimentionalArrayOutput(arr);
            Console.WriteLine();
            Console.WriteLine("Сумма неотрицательных элементов в одномерном массиве: "+ OneDimentionalArraySumOfElements(arr));
            Console.ReadLine();
        }
    }
}
