using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class DateNotTrueException : ApplicationException
    {
        public DateNotTrueException() { }
        public DateNotTrueException(string message) : base(message) { }
        public DateNotTrueException(string message, Exception ex) : base(message, ex) { }
    }
    class User
    {
        protected string surname;
        protected string name;
        protected string patronymic;
        protected DateTime dateOfBirthDay;
        protected int age;
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateOfBirthDay
        { get; set;
            /*get
            {
                return dateOfBirthDay;
            }
            set
            {
                try
                {
                    if (value <= DateTime.Now)
                    {
                        throw new Exception("введена неверная дата рождения!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка: {e.Message}");

                }
            }*/
        }
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
            if (dt > DateTime.Now)
            {
                throw new DateNotTrueException("Дата \"" + dt.ToShortDateString() + "\" не верная!");
            }
            else DateOfBirthDay = dt;
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
    class Employee : User
    {
        protected int workExperience;
        protected string position;
        public int WorkExperience
        { get; set;
            /*get
            {
                return workExperience;
            }
            set
            {
                if ((value >= 0) && (value < Age))
                {
                    workExperience = value;
                }
            }*/
        }
        public string Position { get; set; }
        public Employee(string s, string n, string p, DateTime d, int w, string pos) : base(s, n, p, d)
        {
            if (WorkExperience >= Age)
            {
                throw new Exception("Стаж не может быть больше возраста!");
            }
            else WorkExperience = w;
            Position = pos;
        }
        public void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Стаж работы: " + WorkExperience);
            Console.WriteLine("Должность: " + Position);
        }
    }
    class Program
    {
        static DateTime CheckDateOfBirthDay(string dt)
        {
            DateTime dateTimeBD;
            while (!DateTime.TryParse(GetData(dt), out dateTimeBD) /*|| (dateTimeBD.Year > DateTime.Now.Year)*/)
            {
                Console.WriteLine("Неверная дата!");
            }
            return dateTimeBD;
        }
        static int CheckOfWorkExperience(string workExperience)
        {
            //DateTime dateTimeBD;
            int experience;
            while ((!int.TryParse(GetData(workExperience), out experience))/* || (experience <= 0)*/)
            {
                Console.WriteLine("Неверный стаж работы!");
            }
            return experience;
        }
        static string GetData(string info)
        {
            Console.Write("Введите " + info);
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            try
            {
                Employee intern = new Employee(GetData("фамилию: "),
                                               GetData("имя: "),
                                               GetData("отчество: "),
                                               CheckDateOfBirthDay("дату рождения: "),
                                               CheckOfWorkExperience("стаж работы: "),
                                               GetData("должность: "));
                intern.GetInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
