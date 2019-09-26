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
            int RowsCount;
            while ((!int.TryParse(Console.ReadLine(), out RowsCount)) || (RowsCount <= 0) || (RowsCount > 50))
            {
                Console.Write("Введите колличество строк N: ");
            }

            for (int n = 0; n <= RowsCount; n++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = i; j < RowsCount; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = RowsCount; k >= RowsCount - 2 * i; k--)
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
