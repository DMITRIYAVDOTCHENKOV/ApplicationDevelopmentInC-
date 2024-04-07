/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.seminar_5
{
    internal class ProgramHW6
    {
        private static void Main(string[] args)
        {
            Calc calculator = new Calc();
            calculator.MyEventHandler += (sender, eventArgs) =>
            {
                Console.WriteLine("Результат: " + calculator.Result);
            };

            calculator.Sum(5, 3.5);
            calculator.Divide(8, 2);
            calculator.Multiply(4, 1.5);
        }
    }
}
*/