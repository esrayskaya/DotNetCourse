using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        class MyString
        {
            public char[] str { get; set; }

            private List<char> innerList;
            public List<char> InnerList { get; set; }
            public MyString(char[] charArr)
            {
                InnerList = new List<char>();
                if (charArr != null)
                    InnerList.AddRange(charArr);
            }
            public static MyString operator +(MyString s1, MyString s2)
            {
                char[] temp = (s1.InnerList.Concat(s2.InnerList)).ToArray();
                //char[] temp = (s1.innerList.Union(s2.innerList)).ToArray();
                return new MyString(temp);
            }
            public static MyString operator -(MyString s1, MyString s2)
            {
                for (int j = 0; j < s2.InnerList.Count; j++)
                {
                    s1.InnerList.Remove(s2.InnerList[j]);
                }
                return new MyString(s1.InnerList.ToArray());
            }
            public static bool operator ==(MyString s1, MyString s2)
            {
                int countFalse = 0;
                if (s1.InnerList.Count == s2.InnerList.Count)
                {
                    return true;
                }
                else
                {
                    for (int i = 0; i < s1.InnerList.Count; i++)
                    {
                        if (s1.InnerList[i] != s2.InnerList[i])
                        {
                            countFalse++;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    if (countFalse == s1.InnerList.Count)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            public static bool operator !=(MyString s1, MyString s2)
            {
                int countFalse = 0;
                if (s1.InnerList.Count != s2.InnerList.Count)
                {
                    return true;
                }
                else
                {
                    for (int i = 0; i < s1.InnerList.Count; i++)
                    {
                        if (s1.InnerList[i] != s2.InnerList[i])
                        {
                            countFalse++;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    if (countFalse == s1.InnerList.Count)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            public MyString ToMyString(object obj)
            {
                return obj as MyString;
            }
            public void GetInfo()
            {
                string res = new string(this.InnerList.ToArray());
                Console.WriteLine(res);

            }
            public MyString() { }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую строку: ");
            char[] stringOne = Console.ReadLine().ToCharArray();
            Console.WriteLine("Введите вторую строку: ");
            char[] stringTwo = Console.ReadLine().ToCharArray();

            MyString myStringOne = new MyString(stringOne);
            MyString myStringTwo = new MyString(stringTwo);
            Console.WriteLine("Сложение двух строк: ");
            MyString myStringThree = myStringOne + myStringTwo;
            myStringThree.GetInfo();
            Console.WriteLine("Удаление: ");
            MyString myStringFour = myStringThree - myStringOne;
            myStringFour.GetInfo();
            MyString stringFive = new MyString();
            string str = Console.ReadLine();
            stringFive = stringFive.ToMyString(str);

            Console.ReadLine();
        }
    }
}
