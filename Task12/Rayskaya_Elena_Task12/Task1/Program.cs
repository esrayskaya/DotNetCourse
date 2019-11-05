using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        
        public static List<int> ReadDate(string path)
        {
            List<int> list = new List<int>();
            StreamReader sr = File.OpenText(path);
            try
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    list.Add(int.Parse(line));
                }
                for (int i = 0; i < list.Count; i++)
                {
                    list[i] = list[i] * list[i];
                }
                return list;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return new List<int>();
            }
            finally
            {
                sr.Close();
            }
        }
        static void Main(string[] args)
        {
            string path = @"C:\Users\Lena\DotNetCourse\Task12\disposable_task_file.txt";
            ReadDate(path);
            List<int> list = new List<int>();
            StreamReader sr = File.OpenText(path);
            try
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    list.Add(int.Parse(line));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                sr.Close();
            }
            for(int i = 0; i < list.Count; i++)
            {
                list[i] = list[i] * list[i];
                int a = list[i];
            }
            string writePath= @"C:\Users\Lena\DotNetCourse\Task12\disposable_task_file.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    for(int i = 0; i < list.Count; i++)
                    {
                        sw.WriteLine(list[i].ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
