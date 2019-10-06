using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    class Program
    {
        class MyString
        {
            public char[] str { get; set; }
            
            /* private char[] _stringOne;
             private char[] _stringTwo;
             public char[] StringOne
             { get; set; }
             public char StringTwo
             { get; set; }*/
            //public MyString(char[] _s1) { StringOne = _s1; }
            //public MyString (char[] s1) { str = s1; }
            /*public static MyString operator +(MyString str1, MyString str2)
            {
                return new MyString str = Array.IndexOf<char>str1.str + Array.IndexOf<char>str2.str;
            }*/
            public static MyString operator + (MyString s1, MyString s2)
            {
                char[] temp = s1.str+s2.str;

                return new MyString(temp);
            }

        }
        static void Main(string[] args)
        {
            /*char[] strOne = Console.ReadLine().ToCharArray();
            Console.Write("Введите вторую строку: ");
            char[] strTwo = Console.ReadLine().ToCharArray();*/
            MyString myStringOne = new MyString("kjh".ToCharArray());
            MyString myStringTwo = new MyString("hfb".ToCharArray());
            MyString str3 = myStringOne + myStringTwo;

            Console.ReadLine();
        }
    }
}
