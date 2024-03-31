using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.seminar_5
{
    public interface ICalc
    {
        double Result { get; set; }

        void Sum(int x);
        void Sub(int x);
        void Multu(int x);
        void Divde(int x);

        event EventHandler<EventArgs> MyEventHandler;

        void CancelLast();

    }
}
