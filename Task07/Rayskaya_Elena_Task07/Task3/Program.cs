using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public interface ISeries : IIndexable
    {
        double GetCurrent();
        bool MoveNext();
        void Reset();
    }

    public class ArithmeticalProgression : ISeries, IIndexable
    {
        double start, step;
        int currentIndex;

        public ArithmeticalProgression(double start, double step)
        {
            this.start = start;
            this.step = step;
            this.currentIndex = 1;
        }

        public double GetCurrent()
        {
            return start + step * currentIndex;
        }

        public bool MoveNext()
        {
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = 1;
        }
        public double this[int index]  
        {
            get
            { 
                return start + step * index;
            }
        }
        /*public ISeries this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }*/
    }

    public class List : ISeries
    {
        private double[] series;
        private int currentIndex;

        public List(double[] series)
        {
            this.series = series; 
             currentIndex = 0;
        }

        public double GetCurrent()
        {
            return series[currentIndex];
        }

        public bool MoveNext()
        {
            currentIndex = currentIndex < series.Length - 1 ? currentIndex + 1 : 0;
            return true;
        }

        public void Reset()
        {
            currentIndex = 0;
        }
        public double this[int index]
        {
            get
            {
                return series[index];
            }
        }
    }

    public interface IIndexable 
    {
        double this[int index] { get; }
    }

    interface IIndexableSeries : ISeries, IIndexable
    {
    }
    class Program
    {
        static void PrintSeries(ISeries series)
        {
            series.Reset();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }
        static void PrintIndexable(ISeries series)
        {
            
        }
        static void Main(string[] args)
        {
            ISeries progression = new ArithmeticalProgression(2, 2);
            PrintSeries(progression);
            Console.WriteLine(progression[1].ToString());
            Console.ReadLine();
        }
    }
}
