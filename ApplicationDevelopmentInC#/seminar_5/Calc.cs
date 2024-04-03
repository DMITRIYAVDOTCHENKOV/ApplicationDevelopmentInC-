using System;

namespace ApplicationDevelopmentInC_.seminar_5
{
    internal class Calc : ICalc
    {
        public double Result { get; set; } = 0D;
        private Stack<double> LastResult { get; set; } = new Stack<double>();

        public event EventHandler<EventArgs> MyEventHandler;

        public void PrintResult()
        {
            MyEventHandler?.Invoke(this, EventArgs.Empty);
        }

        public void Divide(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Деление на ноль невозможно.");
                return;
            }
            Result = x / y;
            LastResult.Push(Result);
            PrintResult();
        }

        public void Divide(int x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Деление на ноль невозможно.");
                return;
            }
            Result = x / y;
            LastResult.Push(Result);
            PrintResult();
        }

        public void Multiply(double x, double y)
        {
            Result = x * y;
            LastResult.Push(Result);
            PrintResult();
        }

        public void Multiply(int x, double y)
        {
            Result = x * y;
            LastResult.Push(Result);
            PrintResult();
        }

        public void Subtract(double x, double y)
        {
            Result = x - y;
            LastResult.Push(Result);
            PrintResult();
        }

        public void Subtract(int x, double y)
        {
            Result = x - y;
            LastResult.Push(Result);
            PrintResult();
        }

        public void Sum(double x, double y)
        {
            Result = x + y;
            LastResult.Push(Result);
            PrintResult();
        }

        public void Sum(int x, double y)
        {
            Result = x + y;
            LastResult.Push(Result);
            PrintResult();
        }

        public void CancelLast()
        {
            if (LastResult.TryPop(out double res))
            {
                Result = res;
                Console.WriteLine("Последнее действие отменено. Результат равен: ");
                PrintResult();
            }
            else
            {
                Console.WriteLine("Невозможно отменить последнее действие.");
            }
        }
    }
}
