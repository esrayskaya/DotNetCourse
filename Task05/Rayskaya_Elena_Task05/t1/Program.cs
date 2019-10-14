using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    class User
    {
        private string surname;
        private string name;
        private string patronymic;
        private DateTime dateOfBirthday;
        public string Surname
        { get; set; }
        public string Name
        { get; set; }
        public string Patronymic
        { get; set; }
        public DateTime DateOfBirthDay
        { get; set; }
        public void OutputInfo()
        {
            Console.WriteLine("Фамилия: " + Surname);
            Console.WriteLine("Имя: " + Name);
            Console.WriteLine("Отчество: " + Patronymic);
            Console.WriteLine("Дата рождения: " + DateOfBirthDay.ToShortDateString());
        }
        public string GetAge(DateTime dt)
        {
            string error = "Введена дата больше текущей";
            int age;
            int yearOfBirthDay = dt.Year;
            var dateNow = DateTime.Now;
            int yearNow = dateNow.Year;
            int monthOfBirthDay = dt.Month;
            int monthNow = dateNow.Month;
            if (dt.Year > DateTime.Now.Year)
            {
                return error;
            }
            else if (monthOfBirthDay > monthNow)
            {
                age = yearNow - yearOfBirthDay - 1;
            }
            else
            {
                age = yearNow - yearOfBirthDay;
                Console.WriteLine($"Возраст: {age.ToString()}");
            }
            return age.ToString();
        }
        public User(string s, string n, string p, DateTime d) { Surname = s; Name = n; Patronymic = p; DateOfBirthDay = d; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите фамилию ");
            string surname = Console.ReadLine();
            Console.Write("Введите имя ");
            string name = Console.ReadLine();
            Console.Write("Введите отчество ");
            string patronymic = Console.ReadLine();
            Console.Write("Введите дату рождения ");
            string date = Console.ReadLine();
            DateTime dateDT = DateTime.Parse(date);
            User people = new User(surname, name, patronymic, dateDT);
            people.OutputInfo();
            people.GetAge(dateDT);

            Console.ReadKey();
        }
        
    }
}
