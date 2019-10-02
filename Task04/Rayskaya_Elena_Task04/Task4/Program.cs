using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task4
{
    class Program
    {
        public static void SumString()
        {
            string str = "";
            int N = 100;
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
        }
        public static void SumStringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            int N = 100;
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }

        }
        static void Main(string[] args)
        {
            int N = 100;
            Stopwatch sWatc = new Stopwatch();
            sWatc.Start();
            string str = "";
                        for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            sWatc.Stop();
            //sWatc.Elapsed;
            //Console.WriteLine(Stopwatch.Frequency);
            //Console.WriteLine(sWatc.ElapsedTicks.ToString());//кол-во квантов
            double timeOfSumString = (1.0 / Stopwatch.Frequency) * sWatc.ElapsedTicks;
            //Console.WriteLine((1.0 / Stopwatch.Frequency));
            Console.WriteLine("Время выполнения операци сложения String в с: " + timeOfSumString);

            Stopwatch sWatc2 = new Stopwatch();
            sWatc2.Start();
            StringBuilder sb = new StringBuilder();
            //int N = 100;
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            sWatc2.Stop();
            double timeOfSumStringBuild = (1.0 / Stopwatch.Frequency) * sWatc2.ElapsedTicks;
            //Console.WriteLine(sWatc2.ElapsedTicks.ToString());
            Console.WriteLine("Время выполнения операции сложения StringBuild в с: " + timeOfSumStringBuild);
            Console.ReadLine();
        }
    }
}
