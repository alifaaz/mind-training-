using System;
using System.Collections;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.IO.Compression;
namespace MyApp;

public class Program
{


    static void Main(string[] args)
    {
        MonitorFolder();
    }
    static void WriteFile()
    {
        string path = @"/home/rabab/Documents/oop/example01.txt";
        string text = "Hello File System";
        File.WriteAllText(path, text);
    }
    static void ReadFile()
    {
        string path = @"/home/rabab/Documents/oop/example01.txt";
        Console.WriteLine(File.ReadAllText(path));
    }
    static void AppendText()
    {
        string path = @"/home/rabab/Documents/oop/example01.txt";
        using (var writeNewText = File.AppendText(path))
        {
            writeNewText.WriteLine("New Line Added");
        }
    }
    static void CopyFile()
    {
        string path = @"/home/rabab/Documents/oop/example01.txt";
        string newPath = @"/home/rabab/Documents/oop/new/example01.txt";
        string directory = Path.GetDirectoryName(newPath);
        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }
        if (!File.Exists(path))
        {
            Console.WriteLine("File not found.");
            return;
        }
        File.Copy(path, newPath);
        Console.WriteLine("Copy is succeeded");

    }
    static void MoveFile()
    {
        string path = @"/home/rabab/Documents/oop/example01.txt";
        string newPath = @"/home/rabab/Documents/oop/new/movefile.txt";
        string directory = Path.GetDirectoryName(newPath);

        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }
        if (!File.Exists(path))
        {
            Console.WriteLine("File not found.");
            return;
        }

        File.Move(path, newPath);
        Console.WriteLine("Move is succeeded");
    }
    static void DeletFile()
    {
        string path = @"/home/rabab/Documents/oop/example01.txt";
        if (File.Exists(path))
        {
            File.Delete(path);
            Console.WriteLine("File deleted is succeeded");
        }
        else
        {
            Console.WriteLine("File not Found");
        }
    }
    static void ListFile()
    {
        string path = @"/home/rabab/Documents/oop/new";
        string[] files = Directory.GetFiles(path);
        List<string> filesName = new List<string>();
        string fileName = "";
        for (int i = 0; i < files.Length; i++)
        {
            fileName = Path.GetFileName(files[i]);
            filesName.Add(fileName);
        }
        for (int i = 0; i < files.Length; i++)
        {
            Console.WriteLine(filesName[i]);
        }
    }
    static void ListFileTxtSubDir()
    {
        string path = @"/home/rabab/Documents/oop/new";
        string[] files = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);

        List<string> filesName = new List<string>();
        string fileName = "";
        for (int i = 0; i < files.Length; i++)
        {
            fileName = Path.GetFileName(files[i]);
            filesName.Add(fileName);
        }
        for (int i = 0; i < files.Length; i++)
        {
            Console.WriteLine(filesName[i]);
        }
    }
    // static void GetSizeFileKbMb()
    // {
    //     string path = @"/home/rabab/Documents/oop/new";
    //     string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);//GetSizeFileKbMb
    //     List<string> filesName = new List<string>();
    //     string fileName = "";
    //     foreach (string file in files)
    //     {
    //         fileName = Path.GetFileName(GetSizeFileKbMb(file));
    //         filesName.Add(fileName);
    //     }
    //     for (int i = 0; i < files.Length; i++)
    //     {
    //         Console.WriteLine(filesName[i]);
    //     }
    // }
    static void CountFileWords()
    {
        string path = @"/home/rabab/Documents/oop/new/example01.txt";
        string text = File.ReadAllText(path);
        string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t', '.', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(words.Length);
    }
    static void WriteReadFileStream()
    {
        string path = @"/home/rabab/Documents/oop/example01.txt";
        using (var sw = new StreamWriter(path))
        {
            sw.WriteLine("Hello File System");
        }
        using (var sr = new StreamReader(path))
        {
            while (sr.Peek() > 0)
            {
                Console.WriteLine((char)sr.Read());
            }
        }
    }
    static void MonitorFolder()
    {
        string path = @"/home/rabab/Documents/oop";
        var watcher = new FileSystemWatcher(path, "*.*");
        watcher.Created += (sender, e) =>
        {
            Console.WriteLine($"A new file was created:{e.Name}");
        };
        watcher.EnableRaisingEvents = true;
    }

}