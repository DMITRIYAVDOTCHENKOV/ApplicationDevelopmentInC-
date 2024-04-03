/*using System;
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

                if (!double.TryParse(parts[0], out double number1) || !double.TryParse(parts[1], out double number2))
                {
                    Console.WriteLine("Невозможно преобразовать введенные значения в числа. Попробуйте снова.");
                    continue;
                }

                if (input.Contains('+'))
                    calculator.Sum(number1, number2);
                else if (input.Contains('-'))
                    calculator.Subtract(number1, number2);
                else if (input.Contains('*'))
                    calculator.Multiply(number1, number2);
                else if (input.Contains('/'))
                    calculator.Divide(number1, number2);
            }
        }
    }
}*/