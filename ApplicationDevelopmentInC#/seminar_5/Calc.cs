using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.seminar_5
{
    internal class Calc : ICalc
    {
        public double Result { get; set; } = 0D;
        private Stack<double> Lastresul { get; set; } = new Stack<double>();    

        public event EventHandler<EventArgs> MyEventHandler;

        public void PrintResult()
        {
            MyEventHandler?.Invoke(this, EventArgs.Empty);
        }

        public void Divde(int x)
        {
            PrintResult();
            Result /= x;
            Lastresul.Push(Result);

        }

        public void Multu(int x)
        {
            PrintResult();
            Result *= x;
            Lastresul.Push(Result);

        }

        public void Sub(int x)
        {
            PrintResult();
            Result -= x;
            Lastresul.Push(Result);

        }

        public void Sum(int x)
        {
            PrintResult();
            Result += x;
            Lastresul.Push(Result);

        }

        public void CancelLast()
        {
            if(Lastresul.TryPop(out double res))
            {
                Result = res;
                Console.WriteLine("Последнее действие отменено. Результат равен: ");
                PrintResult();
            }else
            {
                Console.WriteLine("Невозможно отменить посл. действие");
            }
        }
    }
}
