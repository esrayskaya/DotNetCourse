using System;
using System.Globalization;
using System.Text;
using System.Xml;
using System.IO;

namespace Task2
{
    class Observation
    {
        private readonly string PathToCatalog;
        private const string PathForLog = @"C:\Users\Lena\temp.xml";
        public FileSystemWatcher fileWatcher;
        private readonly XmlTextWriter xmlWriter;
        private DirectoryInfo dirInfo;
        public Observation(string pathToCatalog)
        {
            if (!Directory.Exists(pathToCatalog))
            {
                throw new DirectoryNotFoundException(pathToCatalog);
            }
            PathToCatalog = pathToCatalog;
            Console.WriteLine("Наблюдение за каталогом.");
            try
            {
                fileWatcher.Changed += CopyChange;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void CopyChange(object sender, FileSystemEventArgs fileSystemEventArgs)
        {
            /*string writePath = @"C:\Users\Lena\DotNetCourse\Task12\";
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(pathToCatalog);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }*/

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите режим работы\nДля режима наблюдения нажмите - 1\nДля режима отката изменений нажмите - 2");
            if (Console.ReadKey().KeyChar == 49)
            {
                Console.WriteLine(" - Режим наблюдения.");
            }
            if (Console.ReadKey().KeyChar == 50)
            {
                Console.WriteLine(" - Режим отката изменений.");
            }
        //C: \Users\Lena\1
            Console.ReadKey();
        }
    }
}
