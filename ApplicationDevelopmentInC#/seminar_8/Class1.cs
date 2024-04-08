using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.seminar_8
{
    //Напишите консольную утилитку для копирования файла
    internal class Class1
    {
        public void CopyFile(string path, string filename)
        {
            File.Copy(path, filename);
        }
        public void MyCopyFile(string path, string filename)
        {

            if (!Path.Exists(path))
            {
                Console.WriteLine("Файл не найден");
                return;
            }
            using (StreamReader sr = new StreamReader(path))
            {

                using (StreamWriter sr2 = new StreamWriter(filename))
                {
                    sr2.WriteLine(sr.ReadToEnd());
                    Console.WriteLine("Файл записан.");
                }
            }
        }
    }
}
