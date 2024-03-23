/*using ApplicationDevelopmentInC_.lecture_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.lecture_2
{
    internal class Main1
    {
        static void Main(string[] args)
        {


            Person[] people = new Person[] {
        new Woman("Anna", DateTime.Parse("01.01.1990"), 185),
        new Woman("Mariya", DateTime.Parse("01.01.1985"), 180),
        new Woman("Anna", DateTime.Parse("05.11.2000"),170),
        new Man("Dima", DateTime.Parse("01.10.2015"),200),
        new Man("Petya", DateTime.Parse("10.04.2000"), 190),
        new Man("Bob", DateTime.Parse("12.07.1983"), 185)
        };

            Array.Sort(people);

            foreach (var item in people)
            {
                item.Print();
            }
        }
    }
}*/