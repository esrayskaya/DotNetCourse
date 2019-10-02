using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Globalization;

namespace Task3
{
    class Program
    {
        /*public static void OutputCompaireOfCulture(string cultureOne, string cultureTwo)
        {
            for (int i = 0; i < cultureOne.Length; i++)
            {
                if (cultureTwo.Contains(cultureOne[i]))
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(cultureOne[i]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < cultureTwo.Length; i++)
            {
                if (cultureOne.Contains(cultureTwo[i]))
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(cultureTwo[i]);
                }
            }
        }*/
        public static void OutputCompaireOfCulture(string nameOfCultureOne,string nameOfCultureTwo)
        {
            var dataAndTime = DateTime.Now;
            float number = 0.5f;
            decimal money = 15000000m;
            Console.WriteLine("{0,15}|{1,15}|{2,15}", "Название:", nameOfCultureOne, nameOfCultureTwo);
            Console.WriteLine("{0,15}|{1,15}|{2,15}", "Дата:", dataAndTime.ToString("d", CultureInfo.CreateSpecificCulture(nameOfCultureOne)), 
                dataAndTime.ToString("d", CultureInfo.CreateSpecificCulture(nameOfCultureTwo)));
            Console.WriteLine("{0,15}|{1,15}|{2,15}", "Время:", dataAndTime.ToString("t", CultureInfo.CreateSpecificCulture(nameOfCultureOne)), 
                dataAndTime.ToString("t", CultureInfo.CreateSpecificCulture(nameOfCultureTwo)));
            Console.WriteLine("{0,15}|{1,15}|{2,15}", "Дроби:", number.ToString(CultureInfo.CreateSpecificCulture(nameOfCultureOne)), 
                number.ToString(CultureInfo.CreateSpecificCulture(nameOfCultureTwo)));
            Console.WriteLine("{0,15}|{1,15}|{2,15}", "Деньги:", money.ToString("N", CultureInfo.CreateSpecificCulture(nameOfCultureOne)),
                money.ToString("N", CultureInfo.CreateSpecificCulture(nameOfCultureTwo)));
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            /*var dataAndTime = DateTime.Now;
            string nameInvariant = "invariant";

            string nameEngland = "en-US";
            var usCulture = new System.Globalization.CultureInfo(nameEngland);
            
            string dateAndTimeEngland = DateTime.Now.ToString(usCulture.DateTimeFormat);
            string dateOfEnglish = DateTime.Now.ToShortDateString();

            string nameRus = "ru-RU";
            var usCultureRussia = new System.Globalization.CultureInfo(nameRus);
            string dateAndTimeRussia = DateTime.Now.ToString(usCultureRussia.DateTimeFormat);*/

            OutputCompaireOfCulture("en-US", "ru-RU");
            OutputCompaireOfCulture("en-US", "de-DE");
            OutputCompaireOfCulture("de-DE", "ru-RU");
            Console.ReadLine();
        }
    }
}
