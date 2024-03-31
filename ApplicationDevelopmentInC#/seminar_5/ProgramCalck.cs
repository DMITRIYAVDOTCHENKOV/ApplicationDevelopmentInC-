using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.seminar_5
{
    internal class ProgramCalck
    {
        static void Main(string[] args)
        {
            Calc calculator = new Calc();
            calculator.MyEventHandler += (sender, e) => Console.WriteLine(calculator.Result);

            string input;
            while (true)
            {
                Console.WriteLine("Введите арифметическое действие (например, 2+2) или 'end' для завершения:");
                input = Console.ReadLine();

                if (input.ToLower() == "end")
                    break;

                string[] parts = input.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length != 2)
                {
                    Console.WriteLine("Неверный формат ввода. Попробуйте снова.");
                    continue;
                }

                if (!int.TryParse(parts[0], out int number1) || !int.TryParse(parts[1], out int number2))
                {
                    Console.WriteLine("Невозможно преобразовать введенные значения в числа. Попробуйте снова.");
                    continue;
                }

                int result = 0;
                if (input.Contains("+"))
                    result = number1 + number2;
                else if (input.Contains("-"))
                    result = number1 - number2;
                else if (input.Contains("*"))
                    result = number1 * number2;
                else if (input.Contains("/"))
                {
                    if (number2 == 0)
                    {
                        Console.WriteLine("Деление на ноль невозможно.");
                        continue;
                    }
                    result = number1 / number2;
                }

                calculator.Result = result;
                Console.WriteLine("Результат: " + result);
            }
        }
    }
}
