using System.IO;
using static _8._6._1.FileName;

namespace _8._6._1;

internal class Program
{
    static string path;
    static void Main(string[] args)
    {
        Console.WriteLine("Введите путь до папки");

        path = Console.ReadLine();

        CleanDirectory.Cleaner(path);
    }
}
