﻿/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.lectore_8
{
    internal class Class1 : IDisposable
    {
        private bool disposedValue;
        private int handle;

        public void ClassWithResources()
        {
            OpenRes();
            Console.WriteLine("ура я создан");
        }
        private void OpenRes()
        {
            handle = 123;
        }
        private void CloswRes()
        {

        }

        protected virtual void Dispose(bool disposing)
            
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: освободить управляемое состояние (управляемые объекты)
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить метод завершения
                // TODO: установить значение NULL для больших полей
                disposedValue = true;
            }
        }

        // // TODO: переопределить метод завершения, только если "Dispose(bool disposing)" содержит код для освобождения неуправляемых ресурсов
        // ~Class1()
        // {
        //     // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
*/