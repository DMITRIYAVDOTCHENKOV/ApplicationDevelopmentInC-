using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.seminar_4
{
    /*
     * Есть список 
     * отсортировать его в порядке возрастания строк успользуюя лямбу
     */
    internal class Tack3
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>
           {
               "Apple",
               "Banana",
               "Cherry",
               "Date",
               "Fig",
               "Grapes"
           };

            var sordetList = strings.OrderBy(x => x.Length).ToList();
            sordetList.ForEach(Console.WriteLine);
            
        }
    }
}
