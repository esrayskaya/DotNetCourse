using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите первую строку: ");
            string stringOne = Console.ReadLine();
            Console.WriteLine("Ведите вторую строку: ");
            string stringTwo = Console.ReadLine();

            for (int i=0; i < stringOne.Length; i++)
            {
                if ( (stringTwo.Contains(stringOne[i])) && (stringOne[i]!=' ')) 
                {

                    Console.Write(stringOne[i]);
                }
                Console.Write(stringOne[i]);
            }
            /*string str = null;
            for (int i = 0; i < ch1.Length; i++)
            {
                for (int j = 0; j < ch2.Length; j++)
                {
                    if (ch1[i] == ch2[j])
                    {
                        str += ch1[i];
                    }
                }
                str += ch1[i];
            }*/
            //Console.Write(str);
            Console.ReadLine();

        }
    }
}
