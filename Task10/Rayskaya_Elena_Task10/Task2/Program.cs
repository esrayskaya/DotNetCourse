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
    public delegate void SayHello(Person people, DateTime time);
    public delegate void SayBye(Person people);
    public class Office  
    {
        private SayHello greetAll;
        private SayBye byeAll;

        public Office(List<Person> persons)
        {
            foreach (var element in persons)
            {
                element.onCome += OnCameHandler;
                element.onLeave += OnLeaveHandler;

            }
        }
        private void OnCameHandler(Person p, DateTime time)
        {

            Console.WriteLine($"{p.Name} пришел");
            // вызываем все методы приветствия, какие есть
            greetAll?.Invoke(p, time);
            greetAll += p.Greet;
            byeAll += p.SayBye;
        }
        private void OnLeaveHandler(Person p)
        {
            Console.WriteLine($"{p.Name} ушел");
            greetAll -= p.Greet;
            byeAll -= p.SayBye;
            byeAll?.Invoke(p);
        }
    }

    public delegate void OfficeEventHandler(object sender, OfficeEventArgs args);//sender, args
    public delegate void OnCame(Person p, DateTime time);
    public delegate void OnLeave(Person p);


    public class Person
    {
        public string Name { get; set; }
        /*private event OfficeEventHandler Come;
        private event EventHandler Leave;*/
        public event OnCame onCome;
        public event OnLeave onLeave;
        private Office office;
        public void Come(DateTime time)
        {
            onCome?.Invoke(this, time);
        }
        public void Leave()
        {
            onLeave?.Invoke(this);
        }
        
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
    }
    

    class Program
    {
        delegate void Message(string name);
        static void Main(string[] args)
        {
            
            Person lena = new Person { Name="Лена" };
            Person sasha = new Person { Name = "Саша" };
            Person sonya = new Person { Name = "Соня" };
            
            List<Person> list = new List<Person>();
            
            list.Add(lena);
            list.Add(sasha);
            list.Add(sonya);
            Office office = new Office(list);
            /*lena.onCome += lena.Greet;
            sasha.onCome += sasha.Greet;
            sonya.onCome += sonya.Greet;*/
            lena.Come(DateTime.Now);
            sasha.Come(DateTime.Now);
            sonya.Come(DateTime.Now);
            lena.Leave();
            sasha.Leave();
            sonya.Leave();
            
            Console.ReadLine();
        }
        
    }
    
}
