/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ApplicationDevelopmentInC_.seminar_4
{
    internal class Tack1
    {
        *//*
         * Задача 1: 
         * Фильтрация и проэкция данных с ипсользованием LINQ
         * Предоставьте студентам некторую коллекцию объектов(например - список студентов)
         * Найти всех студентов чей возраст больше 25.
         * Вывести имена всех студентов в алфавитном порятдке
         * выбрать всех студентов обучающихся на факультете инженерии
         * посчитать средний возраст студентов
         * использовать LINQ для решения задачи 
         *//*

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student {Name = "Alica", Age = 22, Faculty = "Engineering"},
                new Student {Name = "Dima", Age = 32, Faculty = "Science"},
                new Student {Name = "Eva", Age = 25, Faculty = "Engineering"},
                new Student {Name = "David", Age = 45, Faculty = "Arts"},
                new Student {Name = "Charlie", Age = 26, Faculty = "Java"},
                new Student {Name = "Bob", Age = 50, Faculty = "History"}
            };
            //Перадем лямбду через Where 
            var filterAge = students.Where(x => x.Age < 25);
            //сортируем имена в алфавитном порядке через OrderBy 
            var sotrName = students.OrderBy(x => x.Name).Select(x => x.Name);
            //ищем студентов на определенном факультативе
            var findIngeneres = students.Where(x => x.Faculty.Equals("Engineering"));
            //считаем средний возраст студента
            var averageEga = students.Average(x => x.Age);

            filterAge.ToList().ForEach(x => Console.WriteLine($"{x.Name} - {x.Age}"));
            sotrName.ToList().ForEach(x => Console.WriteLine($"{x},"));
            findIngeneres.ToList().ForEach(x => Console.WriteLine($"{x.Name} - {x.Faculty}"));
            Console.WriteLine(averageEga);

        }
    }
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Faculty { get; set; }
    }

}


*/