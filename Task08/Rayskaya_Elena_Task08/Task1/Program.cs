using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class DynamicArray<T>
    {
        public T[] array;
        int capasity;
        int length;
        int countOfElements;
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
            for(int i = 0; i < Length; i++)
            {
                array[i] = myArray[i];
            }
        }
        public void Add(T element)
        {
            if (Length + 1 > Capasity)
            {
                T[] newArray = new T[Capasity * 2];
                array = newArray;
            }
            else
            {
                array[Length] = element;
                Length++;
            }
        }
        public void AddRange(T[] myArray)
        {
            if (Length + myArray.Length > Capasity)
            {
                T[] newArray = new T[Capasity * 2];
                array = newArray;
            }
            else
            {
                for(int i=0; i < myArray.Length; i++)
                {
                    array[Length] = myArray[i];
                    Length++;
                }
            }
        }
        public bool Remove(int index)
        {
            T[] newArray = new T[Capasity];
            if (index < Length)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i == index)
                    {
                        i++;
                    }
                    else
                    {
                        newArray[i] = array[i];
                    }
                    return true;
                }
                return true;
            }
            else return false;
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
                for(int i = 0; i < array.Length; i++)
                {
                    
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
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
