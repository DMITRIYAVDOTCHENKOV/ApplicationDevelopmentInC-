/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.lecture_4
{
    internal class Ling
    {
        static void Main(string[] args)
        {
            string[] names = { "Анна", "Иван", "Дмитрий", "Николай","Алла","Денис"};

            IEnumerable<string> namesA = from name in names
                                         where name.StartsWith('А')
                                         select name;

            //Альтернативный вариант, более лаконичен
            IEnumerable<string> namesD = names.Where(x => x.StartsWith('Д'));

            //Ищем совпаденря не по первой букве
            IEnumerable<string> namesIndex = names.Where(x => x.StartsWith('А')).Where(x => x[1] == 'л');

            foreach (string name in namesA) { Console.WriteLine(name); }
            foreach (string name in namesD) { Console.WriteLine(name); }
            foreach (string name in namesIndex) { Console.WriteLine(name); }
        }
    }
}
*/