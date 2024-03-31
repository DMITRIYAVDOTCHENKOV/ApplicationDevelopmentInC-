/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.seminar_5
{
    internal class Program
    {
        delegate void myDeligate(string message);

        static void Main(string[] args)
        {
            *//*            //Создайте метод, который принимает список действий (делагат Action)  и выполняет их последователньо 
                        List<Action> list = new List<Action>();
                        list.Add(Print);
                        list.Add(Print2);

                        doAcction(list);    *//*

            List<myDeligate> myDeligates = new List<myDeligate>()
            {
                (message) => Console.WriteLine($"1 delegate = {message}"),
                (message) => Console.WriteLine($"2 delegate = {message}"),
            };
            PrintDeligate(myDeligates);
        }


        static void PrintDeligate(List<myDeligate> deligates)
        {
            foreach (var item in deligates)
            {
                item("message");
            }
        }

        static void Print()
        {
            Console.WriteLine("111");
        }

        static void Print2()
        {
            Console.WriteLine("222");
        }
        static void doAcction(List<Action> listAction)
        {
            foreach (var item in listAction)
            {
                item();
            }
        }
    }
}
*/