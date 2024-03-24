/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.seminar_4
{
    internal class Tack2
    {
        *//*
         * Отсортировать хаказы по сумме возростанию и убывванию
         * Сгрупировать заказы по клиентам и вывести кол-во заказво для каждого
         * Найти клиента с наибольшей суммой
         * Вывести список клиентов и их общую сумму 
         * 
         *//*
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>()
            {
                new Order {OrderId = 1, CustomerName = "Alice", OrderDate = new DateTime(2024,6,1), TotalAmount = 146.4},
                new Order {OrderId = 1, CustomerName = "Alice", OrderDate = new DateTime(2023,6,1), TotalAmount = 200.90},
                new Order {OrderId = 1, CustomerName = "Alice", OrderDate = new DateTime(2022,6,1), TotalAmount = 300.0},
                new Order {OrderId = 1, CustomerName = "Bod", OrderDate = new DateTime(2023,5,6), TotalAmount = 100.4},
                new Order {OrderId = 1, CustomerName = "Bod", OrderDate = new DateTime(2022,6,3), TotalAmount = 180.4},
                new Order {OrderId = 1, CustomerName = "Bod", OrderDate = new DateTime(2024,10,6), TotalAmount = 346.4},
                new Order {OrderId = 1, CustomerName = "David", OrderDate = new DateTime(2023,10,5), TotalAmount = 10.4},
                new Order {OrderId = 1, CustomerName = "David", OrderDate = new DateTime(2023,1,1), TotalAmount = 180.2},
                new Order {OrderId = 1, CustomerName = "David", OrderDate = new DateTime(2024,3,6), TotalAmount = 258.1},
                new Order {OrderId = 1, CustomerName = "Dima", OrderDate = new DateTime(2023,7,8), TotalAmount = 569.7},
                new Order {OrderId = 1, CustomerName = "Dima", OrderDate = new DateTime(2024,3,1), TotalAmount = 14.4},
                new Order {OrderId = 1, CustomerName = "Dima", OrderDate = new DateTime(2022,10,8), TotalAmount = 46.3},
                new Order {OrderId = 1, CustomerName = "Dima", OrderDate = new DateTime(2021,11,2), TotalAmount = 1246.4}
            };
            //Сортировка по сумме
            var sum = orders.OrderByDescending(x => x.TotalAmount);
            var su2 = from order in orders
                      orderby order.TotalAmount
                      select order;

            //Групировка заказов и вывод общее кол-вл заказов
            var totalAmountForClient = orders.GroupBy(x => x.CustomerName).Select(x => new { name = x.Key, count = x.Count() });

            //С наибольшей суммой заказа
            var richClient = orders.GroupBy(x => x.CustomerName)
                .Select(x => new { name = x.Key, sumTotalAmount = x.Sum(ta => ta.TotalAmount) })
                .OrderBy(ta => ta.sumTotalAmount).First().name;

            //список клиентов и общую сумму заказа 
            var clientsTA = orders.GroupBy(x => x.CustomerName)
                .Select(x => new { name = x.Key, sumTotalAmount = x.Sum(ta => ta.TotalAmount) });


            Console.WriteLine("Сортировка по сумме");
            sum.ToList().ForEach(x => Console.WriteLine($"{x.CustomerName} - {x.TotalAmount}"));
            Console.WriteLine("Групировка заказов и вывод общее кол-вл заказов");
            totalAmountForClient.ToList().ForEach(x => Console.WriteLine($"{x.name} {x.count}, "));
            Console.WriteLine("С наибольшей суммой заказа");
            Console.WriteLine(richClient);
            Console.WriteLine("список клиентов и общую сумму заказа ");
            clientsTA.ToList().ForEach(x => Console.WriteLine($"{x.name} - {x.sumTotalAmount}"));


        }

        class Order
        {
            public int OrderId { get; set; }
            public string CustomerName { get; set; }
            public DateTime OrderDate { get; set; }
            public double TotalAmount { get; set; }
        }
    }
}
*/