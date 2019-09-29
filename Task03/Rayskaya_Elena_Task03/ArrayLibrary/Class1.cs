using System;

namespace ArrayLibrary
{
    public class Class1
    {
        public static void OneDimentionalArrayFilling(ref int[] a)
        {
            Random rand = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(-50, 50);
            }
        }
        public static void OneDimentionalArrayOutput(ref int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(String.Format("{0,4}", a[i]));
                //Console.Write(String.Format("a[" + i + "]=" + a[i]) + " ");
            }
        }
    }
}
