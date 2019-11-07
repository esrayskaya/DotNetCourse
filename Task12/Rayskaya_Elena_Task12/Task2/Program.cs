using System;
using System.Globalization;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Text.RegularExpressions;

namespace Task2
{
    class Observation
    {
        private readonly string PathToCatalog;//путь к отслеживаемой директории
        public FileSystemWatcher fileWatcher;
        private DirectoryInfo dirInfo;
        public Observation(string pathToCatalog)
        {
            
            if (!Directory.Exists(pathToCatalog))
            {
                throw new DirectoryNotFoundException(pathToCatalog);
            }
            Console.WriteLine("Наблюдение за каталогом.");
            try
            {
                dirInfo = new DirectoryInfo(pathToCatalog);
                if (Directory.Exists(pathToCatalog))
                {
                    //PathToCatalog = pathToCatalog;
                    PathToCatalog = dirInfo.FullName;
                    Console.WriteLine(PathToCatalog);
                    Console.WriteLine("Файлы в директории:");
                    List<FileInfo> list = new List<FileInfo>(dirInfo.GetFiles("*.txt", SearchOption.AllDirectories));
                    foreach(FileInfo element in list)
                    {
                        Console.WriteLine(element);
                    }
                }
                fileWatcher = new FileSystemWatcher(PathToCatalog);
                fileWatcher.EnableRaisingEvents = true;
                fileWatcher.Filter = "*.txt";
                fileWatcher.IncludeSubdirectories = true;
                fileWatcher.Changed += FileWatcherOnChanged;
                fileWatcher.Created += FileWatcherOnCreated;
                fileWatcher.Deleted += FileWatcherOnDeleted;
                fileWatcher.Renamed += FileWatcherOnRenamed;

                Thread.Sleep(10000);
                
                Console.WriteLine("Подписки закончились.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        public void FileWatcherOnChanged(object sender, FileSystemEventArgs fileSystemEventArgs)
        {
            Console.WriteLine($"Файл {fileSystemEventArgs.FullPath} в директории изменен {fileSystemEventArgs.ChangeType}.");
            CopyOfChangeInHelpDirectory();
        }
        public void FileWatcherOnCreated(object sender, FileSystemEventArgs fileSystemEventArgs)
        {
            Console.WriteLine($"Файл {fileSystemEventArgs.FullPath} в директории {fileSystemEventArgs.ChangeType}.");
            CopyOfChangeInHelpDirectory(/*PathToCatalog*/);
        }
        public void FileWatcherOnDeleted(object sender, FileSystemEventArgs fileSystemEventArgs)
        {
            Console.WriteLine($"Файл {fileSystemEventArgs.FullPath} в директории {fileSystemEventArgs.ChangeType}.");
            CopyOfChangeInHelpDirectory(/*PathToCatalog*/);
        }
        public void FileWatcherOnRenamed(object sender, FileSystemEventArgs fileSystemEventArgs)
        {
            Console.WriteLine($"Файл {fileSystemEventArgs.FullPath} в директории {fileSystemEventArgs.ChangeType}.");
            CopyOfChangeInHelpDirectory(/*PathToCatalog*/);
        }
        public void CopyOfChangeInHelpDirectory(/*string oldName*/)
        {
            string ToDir= @"C:\Users\Lena\temp"+  DateTime.Now.ToString("dd.MM.yyyy hh-mm-ss");
            Directory.CreateDirectory(ToDir);
            foreach (string s1 in Directory.GetFiles(dirInfo.FullName))
            {
                string s2 = ToDir + "\\" + Path.GetFileName(s1);
                File.Copy(s1, s2);
            }
            Console.WriteLine("Файлы скопированы");
        }
    }
    public class Rollback
    {
        private readonly string PathToCatalog;//путь к отслеживаемой директории
        private DirectoryInfo dirInfo;
        public Rollback(DateTime dt)
        {
            string date = dt.ToShortDateString();
            string pathToCatalog = @"C:\Users\Lena";
            dirInfo = new DirectoryInfo(pathToCatalog);
            //string fileName = "temp" + dt + "[0-9][0-9].[0-9][0-9].[0-9][0-9]";
            //if(Regex.IsMatch())
            //string[] findFiles = System.IO.Directory.GetDirectories(pathToCatalog, "temp07.11.2019 08-16-48", System.IO.SearchOption.AllDirectories);
            /*foreach (string file in findFiles)
            {
                Console.WriteLine(file);
            }*/
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите режим работы\nДля режима наблюдения нажмите - 1\nДля режима отката изменений нажмите - 2");
            int x = Console.ReadKey().KeyChar;
            /*while (x != 49 || x != 50)
            {
                Console.WriteLine(" - Выберите режим работы\nДля режима наблюдения нажмите - 1\nДля режима отката изменений нажмите - 2");
                x = Console.ReadKey().KeyChar;
                if (x == 49 || x == 50) { break; }
            }*/
            if (x == 49)
            {
                Console.WriteLine(" - Режим наблюдения.");
                Observation obs = new Observation(@"C:\Users\Lena\1");
            }
            if (x == 50)
            {
                Console.WriteLine(" - Режим отката изменений.");
                Console.WriteLine("Введите дату отката: ");
                DateTime dt = DateTime.Parse(Console.ReadLine());
                Rollback rollback = new Rollback(dt);
            }
            Console.ReadLine();
        }
    }
}
