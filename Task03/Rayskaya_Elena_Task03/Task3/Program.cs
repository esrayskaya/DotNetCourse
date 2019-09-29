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
        static int OneDimentionalArraySumOfElements(ref int[] a)
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
            int sum = 0;
            int[] arr = new int[n];
            Class1.OneDimentionalArrayFilling(ref arr);
            Console.WriteLine("Одномерный массив:");
            Class1.OneDimentionalArrayOutput(ref arr);
            Console.WriteLine();
            Console.WriteLine("Сумма неотрицательных элементов в одномерном массиве: "+ OneDimentionalArraySumOfElements(ref arr));
            Console.ReadLine();
        }
    }
}
