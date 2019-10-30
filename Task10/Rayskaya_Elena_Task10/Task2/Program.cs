using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class OfficeEventArgs : EventArgs
    {
        public DateTime Time { get; }

        public OfficeEventArgs(DateTime time)
        {
            Time = time;
        }
    }
    public class Office : HashSet<Person> // Офис - Список из неповторяющихся элементов
    {

    }
    public delegate void OfficeEventHandler(object sender, OfficeEventArgs args);//sender, args

    
    public class Person
    {
        private string Name { get; }
        private event OfficeEventHandler Come;
        private event EventHandler Leave;
        private Office office;

        //public  string Name { get; set; }

        public delegate void ComeDelegate(Person people);
        public event ComeDelegate PeopleCome;
        public void Greet(Person people, DateTime time)
        {
            string hello;
            if ((time.Hour < 10) && (time.Hour > 5))
            {
                hello = "Доброе утро";
            }
            else if ((time.Hour > 10) && (time.Hour < 17))
            {
                hello =  "Добрый день";
            }
            else
            {
                hello =  "Доброй ночи";
            }
            Console.WriteLine($"'{hello}, {people.Name}' - сказал {Name}");
        }
        public void SayBye(Person people)
        {
            string bye = "До свидвния";
            Console.WriteLine($"'{bye}, {people.Name}' - сказал {Name}");
        }
        public void OnCome(DateTime time)
        {
            foreach (var person in office)
            {
                Come += (sender, args) => { person.Greet(this, time); };
            }
            //Console.WriteLine($"{Name} пришел на работу в {time}.");
            Console.WriteLine(Name + " пришел на работу");
            Come?.Invoke(this, new OfficeEventArgs(time));
            office.Add(this);
        }
        public void OnLeave()
        {
            office.Remove(this); // Сначала удалить из офиса. Оставшиеся начнут прощаться
            foreach (var person in office)
            {
                Leave += (sender, args) => { person.SayBye(this); };
            }
            Console.WriteLine($"{Name} ушел с работы.");
            Leave?.Invoke(this, new EventArgs());

        }
        public Person(string name, Office office)
        {
            Name = name;
            this.office = office;
        }
    }
    

    class Program
    {
        delegate void Message(string name);
        static void Main(string[] args)
        {
            Office office = new Office();
            Person lena = new Person("Лена", office);
            Person sasha = new Person("Саша", office);
            Person vova = new Person("Вова", office);
            lena.OnCome(DateTime.Now);
            sasha.OnCome(DateTime.Now);
            vova.OnCome(DateTime.Now);
            lena.OnLeave();
            sasha.OnLeave();
            vova.OnLeave();
            Console.ReadLine();
        }
        
    }
    
}
