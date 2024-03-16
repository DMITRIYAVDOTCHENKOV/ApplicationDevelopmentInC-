using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.seminar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bits b1 = new Bits(10); // Инициализация объекта Bits с помощью int
            Bits b2 = new Bits((long)20); // Инициализация объекта Bits с помощью long
            Bits b3 = (Bits)5; // Преобразование целочисленного значения в объект Bits

            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);
        }
    }
}
