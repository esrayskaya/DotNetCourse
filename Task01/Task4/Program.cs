using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите колличество строк N: ");
            int rowsCount;
            while ((!int.TryParse(Console.ReadLine(), out rowsCount)) || (rowsCount <= 0) || (rowsCount > 50))
            {
                Console.Write("Введите колличество строк N: ");
            }

            for (int n = 0; n <= rowsCount; n++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = i; j < rowsCount-1; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = rowsCount; k >= rowsCount - 2 * i; k--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
