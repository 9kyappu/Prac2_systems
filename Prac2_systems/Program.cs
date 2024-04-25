using System;
using System.IO;

class Prac2
{
    //public static void Main()
    //{
    //    DriveInfo[] allDrives = DriveInfo.GetDrives();
    //    foreach (DriveInfo d in allDrives)
    //    {
    //        Console.WriteLine("-------------------------------------------");
    //        Console.WriteLine("Имя диска: {0}", d.Name);
    //        Console.WriteLine("Объём диска: {0} байт ({1} Гб)", d.TotalSize, (d.TotalSize / (1024 * 1024 * 1024)));
    //        Console.WriteLine("Свободное пространство на диске: {0} байт ({1} Гб)", d.TotalFreeSpace, (d.TotalFreeSpace / (1024 * 1024 * 1024)));
    //        Console.WriteLine("Метка диска: {0}", d.VolumeLabel);
    //    }
    //}
    //static void Main()
    //{
    //    string root = "E:\\";
    //    DisplayFileSystemEntries(root, 0);
    //}

    //static void DisplayFileSystemEntries(string path, int indent)
    //{
    //    try
    //    {
    //        Console.WriteLine("Подкаталоги:");
    //        string[] dirs = Directory.GetDirectories(path);
    //        foreach (string s in dirs)
    //        {
    //            Console.WriteLine(s);
    //        }
    //        Console.WriteLine("-------------------------------");
    //        Console.WriteLine("Файлы:");
    //        string[] files = Directory.GetFiles(path);
    //        foreach (string s in files)
    //        {
    //            Console.WriteLine(s);
    //        }
    //    }
    //    catch (Exception e)
    //    {
    //        Console.WriteLine(e.Message);
    //    }
    //}

    //static void Main()
    //{
    //    string root = "H:\\";
    //    DisplayFirstLevelFileSystemEntries(root, "*.txt"); // Измените фильтр по необходимости
    //}

    //static void DisplayFirstLevelFileSystemEntries(string path, string searchPattern)
    //{
    //    try
    //    {
    //        Console.WriteLine("Подкаталоги:");
    //        string[] dirs = Directory.GetDirectories(path);
    //        foreach (string s in dirs)
    //        {
    //            Console.WriteLine(s);
    //        }
    //        Console.WriteLine("-------------------------------");
    //        Console.WriteLine("Файлы:");
    //        string[] files = Directory.GetFiles(path, searchPattern);
    //        foreach (string s in files)
    //        {
    //            Console.WriteLine(s);
    //        }
    //    }
    //    catch (Exception e)
    //    {
    //        Console.WriteLine(e.Message);
    //    }
    //}
    static void Main()
    {
        // Путь к файлу
        string filePath = "Mishin.mishiN";

        // Запись информации в файл
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Это любая информация, которую нужно записать в файл.");
        }

        // Чтение информации из файла
        using (StreamReader reader = new StreamReader(filePath))
        {
            string content = reader.ReadToEnd();
            Console.WriteLine(content);
        }
    }
}
