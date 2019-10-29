using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Person
    {
        private string name;
        public  string Name { get; set; }
        public void Greet()
        {
            Console.WriteLine(Name);
        }
       /* public Person()
        {
            Name = name;
        }*/
    }
    class Program
    {
        delegate void Message(); // 1. Объявляем делегат
        private static void GoodMorning()
        {
            Console.WriteLine("Good Morning");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Good Evening");
        }
        static void Main(string[] args)
        {
            Person john = new Person { Name = "John" };
            Person mary = new Person { Name = "Mary" };
            Person hugo = new Person { Name = "Hugo" };
            Message mes; // 2. Создаем переменную делегата
            Message mes1 = john.Greet;
            if (DateTime.Now.Hour < 12)
            {
                Message greetByJohn = new Message(john.Greet);
                Message greetByMary = new Message(mary.Greet);
                Message greetByHugo = new Message(hugo.Greet);
                //mes1 = john.Greet;
                mes =mes1+  GoodMorning; // 3. Присваиваем этой переменной адрес метода
                
            }
            else
            {
                mes = GoodEvening;
            }
            mes(); // 4. Вызываем метод
            Console.ReadKey();
        }
        
    }
    
}
