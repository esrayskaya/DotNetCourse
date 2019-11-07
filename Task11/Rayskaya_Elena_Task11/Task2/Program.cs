using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    //public interface IEquatable
    class Employee : IEquatable<Employee>
    {
        protected string surname;
        protected string name;
        protected int workExperience;
        protected string position;
        public int WorkExperience
        { get; set; }
        public string Position { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public Employee(string surename, string name, int workExperience, string position)
        {
            Surname = surename;
            Name = name;
            WorkExperience = workExperience;
            Position = position;
        }
        public bool Equals(Employee otherEmployee)
        {
            if (otherEmployee == null)
            {
                return false;
            }
            if ((this.Name == otherEmployee.Name) && (this.Surname == otherEmployee.Surname))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if(((object)employee1==null) || ((object)employee2 == null))
            {
                return Object.Equals(employee1, employee2);
            }
            return employee1.Equals(employee2);
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (((object)employee1 != null) || ((object)employee2 != null))
            {
                return !Object.Equals(employee1, employee2);
            }
            return !employee1.Equals(employee2);
        }
        public override int GetHashCode()
        {
            return this.WorkExperience.GetHashCode()^(this.WorkExperience.GetHashCode()+1);
        }
        public override string ToString()
        {
            return $"Фамилия: {Surname}\nИмя: {Name}\nСтаж работы: {WorkExperience}\nДолжность: {Position}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Ivanov", "Ivan", 1, "intern");
            Employee employee2 = new Employee("Petrov", "Petr", 5, "developer");
            Employee employee3 = new Employee("Ivanov", "Ivan", 1, "intern");
            List<Employee> list = new List<Employee>();
            list.Add(employee1);
            list.Add(employee2);
            Console.WriteLine($"Сотрудники:\n{employee1.ToString()}\n\n{employee2.ToString()}\n\n{employee3.ToString()}\n");
            Console.WriteLine($"HasnCode 1 сотрудника: {employee1.GetHashCode()}");
            Console.WriteLine($"Проверка на равенсто 1 и 2 сотрудников: {employee1.Equals(employee2)}");
            Console.WriteLine($"Проверка на равенсто 1 и 3 сотрудников: {employee1.Equals(employee3)}");
            Console.ReadLine();
        }
    }
}
