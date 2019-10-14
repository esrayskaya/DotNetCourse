using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class User
    {
        private string surname;
        private string name;
        private string patronymic;
        private DateTime dateOfBirthDay;
        private int age;
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateOfBirthDay
        { get; set; }
        public int Age
        {
            get { return AgeCalculation(DateOfBirthDay); }
        }
        public static int AgeCalculation(DateTime dt)
        {
            int age;
            int yearOfBirthDay = dt.Year;
            var dateNow = DateTime.Now;
            int yearNow = dateNow.Year;
            int monthOfBirthDay = dt.Month;
            int monthNow = dateNow.Month;
            
            if (monthOfBirthDay > monthNow)
            {
                age = yearNow - yearOfBirthDay - 1;
            }
            else
            {
                age = yearNow - yearOfBirthDay;
                //Console.WriteLine($"Возраст: {age.ToString()}");
            }
            return age;
        }
        public User(string s, string n, string p, DateTime dt)
        {
            Surname = s;
            Name = n;
            Patronymic = p;
            DateOfBirthDay = dt;
        }
        public void GetInfo()
        {
            Console.WriteLine("Фамилия: " + Surname);
            Console.WriteLine("Имя: " + Name);
            Console.WriteLine("Отчество: " + Patronymic);
            Console.WriteLine("Дата рождения: " + DateOfBirthDay.ToShortDateString());
            Console.WriteLine("Возраст: " + Age);
        }
        
    }
    class Program
    {
        static DateTime CheckDateOfBirthDay(string dt)
        {
            DateTime dateTimeBD;
            while (!DateTime.TryParse(GetData(dt), out dateTimeBD) || (dateTimeBD.Year > DateTime.Now.Year))
            {
                Console.Write("");
            }
            return dateTimeBD;
        }
        static string GetData(string info)
        {
            Console.Write("Введите " + info);
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            User people = new User(GetData("фамилию: "), GetData("имя: "), GetData("отчество: "), CheckDateOfBirthDay("дату рождения: "));
            /*Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите отчество: ");
            string patronymic = Console.ReadLine();
            Console.Write("Введите дату рождения: ");
            string date = Console.ReadLine();
            DateTime dt =CheckDateOfBirthDay(date);
            User people = new User(surname, name, patronymic, dt);*/
            people.GetInfo();

            Console.ReadKey();
        }
    }
}
