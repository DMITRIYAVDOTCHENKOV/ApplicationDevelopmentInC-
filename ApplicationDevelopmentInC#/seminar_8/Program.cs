/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.seminar_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Недостаточно аргументов. Пример вызова: utility.exe txt текст");
                return;
            }

            string extension = args[0];
            string searchText = args[1];

            string currentDirectory = Directory.GetCurrentDirectory();
            SearchFiles(currentDirectory, extension, searchText);
        }

        static void SearchFiles(string directory, string extension, string searchText)
        {
            try
            {
                string[] files = Directory.GetFiles(directory, $"*.{extension}");

                foreach (string file in files)
                {
                    if (File.ReadAllText(file).Contains(searchText))
                    {
                        Console.WriteLine($"Файл найден: {file}");
                    }
                }

                string[] subDirectories = Directory.GetDirectories(directory);

                foreach (string subDir in subDirectories)
                {
                    SearchFiles(subDir, extension, searchText);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка поиска файлов: {e.Message}");
            }
        }
    }
}*/