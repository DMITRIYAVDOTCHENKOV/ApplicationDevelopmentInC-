using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApplicationDevelopmentInC_.seminar3
{
    internal class getArray
    {
        public void MyArray()
        {
            List<int> ints = new List<int>() { 0, 1, 2, 3, 19, 1000, -56, 454, 78, -98, 0, 1, 2, 1000 };
            List<int> array = new List<int>();

            foreach (var item in ints)
            {
                if (!array.Contains(item))
                {
                    array.Add(item);
                }
            }
            array.ForEach(Console.WriteLine);
        }
        public void MyArray2()
        {
            List<int> ints = new List<int>() { 0, 1, 2, 3, 19, 1000, -56, 454, 78, -98, 0, 1, 2, 1000 };
            ints = ints.Distinct().ToList();

            ints.ForEach(Console.WriteLine);
        }

        //Дан список целых чисел )числа не послдеовательны), где некторые числа повторяются. Вывести список чисел в порядке возрастания частоты повторения

        public void MyArraySort() 
        {
            List<int> ints = new List<int> { 1, 1, 3, 4, 5, 4, 5, 7, 8, 9, 44, 44, 2, 2, 44, 23, 44, 09 };
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var value in ints)
            {
                if (dict.ContainsKey(value))
                {
                    dict[value]++;
                }
                else
                {
                    dict.Add(value, 1);
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }
            dict.OrderByDescending(x => x.Key);
            Console.WriteLine(dict);
        }
    }
}