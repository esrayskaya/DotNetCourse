using System;
using System.Collections.Generic;

namespace Common
{
    public class User
    {
        private int id;
        private string firstName;
        private string lastName;
        private DateTime dateOfBirthDay;
        private int age;
        List<Award> awardsList;
        public List<Award> AwardsList
        {
            get
            {
                return awardsList;
            }
        }
        public string usersAwarda { get; set; }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public override int GetHashCode()
        {
            return DateOfBirthDay.Year ^ DateOfBirthDay.Month ^ DateOfBirthDay.Day ^ DateTime.Now.Minute;
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Поле не может быть пустым.");
                }
                else if (value.Length > 50)
                {
                    throw new Exception("Длина строки не может быть больше 50.");
                }
                else firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                /*if (value == null)
                {
                    throw new Exception("Поле не может быть пустым.");
                }
                else if (value.Length > 50)
                {
                    throw new Exception("Длина строки не может быть больше 50.");
                }
                else*/
                lastName = value;
            }
        }
        public DateTime DateOfBirthDay
        {
            get { return dateOfBirthDay; }
            set
            {
                dateOfBirthDay = value;
            }
        }
        public int Age
        {
            get { return AgeCalculation(DateOfBirthDay); }
            set { age = value; }
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
            }
            return age;
        }
        public User(int ID, string firstName, string lastName, DateTime dt)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirthDay = dt;
            //awardsList = new List<Award>();
            this.ID = ID;
            awardsList = new List<Award>();
        }
         public User(string name, string surname, DateTime dt)
         {
             FirstName = name;
             LastName = surname;
             DateOfBirthDay = dt;
            awardsList = new List<Award>();

        }
    }
}
