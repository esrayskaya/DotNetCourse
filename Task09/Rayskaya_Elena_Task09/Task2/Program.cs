using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        class DynamicArray<T>
        {
            public T[] array;
            int capasity;
            int length;
            public int Capasity
            {
                get { return array.Length; }
            }
            public int Length
            {
                get { return length; }
                set
                {
                    if (value >= 0)
                    {
                        length = value;
                    }
                }
            }
            public DynamicArray()
            {
                T[] array = new T[8];
                Length = 0;
            }
            public DynamicArray(int myCapasity)
            {
                T[] array = new T[myCapasity];
                Length = 0;
            }
            public DynamicArray(T[] myArray)
            {
                Length = myArray.Length;
                for (int i = 0; i < Length; i++)
                {
                    array[i] = myArray[i];
                }
            }
            public DynamicArray(IEnumerable<T> col)
            {
                array = col.ToArray();
                Length = array.Length;
            }
            public void Add(T element)
            {
                Insert(element, Length);
            }
            public void AddRange(T[] myArray)
            {
                if (Length + myArray.Length > Capasity)
                {
                    T[] newArray = new T[Capasity * 2];
                    array = newArray;
                }
                /// else
                {
                    for (int i = 0; i < myArray.Length; i++)
                    {
                        array[Length] = myArray[i];
                        Length++;
                    }
                }
            }
            public bool Remove(int index)
            {
                T[] newArray = new T[Capasity];
                if (index > Length)
                {
                    return false;
                }
                else
                {
                    if (index == 0)
                    {
                        for (int i = 1; i < array.Length; i++)
                        {
                            newArray[i] = array[i];
                        }
                    }
                    for (int i = index; i < array.Length; i++)
                    {
                        newArray[i] = array[i];
                    }
                    return true;
                }
            }
            public T[] Insert(T element, int index)
            {
                T[] newArray = new T[Capasity];
                if (index > Length)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (i < index)
                        {
                            newArray[i] = array[i];
                        }
                        else if (i == index)
                        {
                            newArray[i] = array[index];
                        }
                        else if (i > index)
                        {
                            newArray[i] = array[i + 1];
                        }
                    }
                }
                return newArray;
            }
            public T this[int index]
            {
                get
                {
                    if (index > Capasity)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    return array[index];
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
