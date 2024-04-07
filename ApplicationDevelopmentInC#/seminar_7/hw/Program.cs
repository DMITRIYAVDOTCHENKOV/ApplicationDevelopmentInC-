/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.seminar_7.hw
{
    internal class Program
    {
        public static void Main()
        {
            // Создаем экземпляр класса MyClass
            MyClass myObject = new MyClass();

            // Вызываем метод ObjectToString, чтобы сохранить значения полей в строку
            string objectAsString = ObjectExtensions.ObjectToString(myObject);
            Console.WriteLine(objectAsString);

            // Имитируем данные для метода StringToObject
            string data = "CustomFieldName:10";

            // Используем метод StringToObject, чтобы установить значения полей из строки
            ObjectExtensions.StringToObject(myObject, data);
            Console.WriteLine($"New value of I is {myObject.I}");
        }
    }
}*/