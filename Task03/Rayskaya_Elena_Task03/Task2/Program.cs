using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void ThreeDimentionArrayFilling(int[,,] a)
        {
            Random rand = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    for (int k = 0; k < a.GetLength(2); k++)
                    {
                        a[i, j, k] = rand.Next(-50, 50);
                    }
                }
            }
        }
        static void ThreeDimentionalArrayOutput(int[,,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.WriteLine();
                Console.Write("(");
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("(");
                    for (int k = 0; k < a.GetLength(2); k++)
                    {
                        Console.Write(String.Format("{0,4}", a[i, j, k]));
                    }
                    Console.Write(")");
                }
                Console.Write(")");
            }
        }
        static void ThreeDimentionalArrayReplacemantOfElements(int[,,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    for (int k = 0; k < a.GetLength(2); k++)
                    {
                        if (a[i, j, k] > 0)
                        {
                            a[i, j, k] = 0;
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //int[,,] array = { { { 1, 2, 3 }, { 4, 5, 6 } } };
            int n=2, m=2, l=3;
            int[,,] arr = new int[n, m, l];
            Console.Write("Исходный трехмерный массив: ");
            ThreeDimentionArrayFilling(arr);
            ThreeDimentionalArrayOutput(arr);
            ThreeDimentionalArrayReplacemantOfElements(arr);
            Console.WriteLine();
            Console.Write("Трехмерный массив с замененными положительными элементами: ");
            ThreeDimentionalArrayOutput(arr);
            Console.ReadLine();
        }
    }
}
