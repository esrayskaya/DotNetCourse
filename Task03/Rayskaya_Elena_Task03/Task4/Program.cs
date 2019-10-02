using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void TwoDimentionalArrayFilling(int[,] a)
        {
            Random rand = new Random();
            for (int i=0; i < a.GetLength(0); i++)
            {
                for (int j=0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rand.Next(-50, 50);
                }
            }
        }
        static void TwoDimentionalArrayOutput(int[,] a)
        {
            Random rand = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0,4}", a[i, j]));
                }
                Console.WriteLine();
            }
        }
        static int TwoDimensionalArraySumOfElementsInEvenPosition(int[,] a)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        //Console.WriteLine(array[i, j]);
                        sum += a[i, j];
                    }
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int n = 5;
            int m = 6;
            int[,] arr = new int[n, m];
            TwoDimentionalArrayFilling(arr);
            Console.WriteLine("Двумерный массив:");
            TwoDimentionalArrayOutput(arr);
            Console.Write("Сумма элементов, стоящих на четных позициях: " + TwoDimensionalArraySumOfElementsInEvenPosition(arr));
            Console.ReadLine();
        }
    }
}
