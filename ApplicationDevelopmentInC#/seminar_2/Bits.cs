using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.seminar_2
{
    internal class Bits
    {
        private int value;

        public Bits(int value)
        {
            this.value = value;
        }

        public Bits(long value)
        {
            this.value = (int)value;
        }

        public static implicit operator Bits(int value)
        {
            return new Bits(value);
        }

        public static implicit operator Bits(long value)
        {
            return new Bits(value);
        }

        public static implicit operator Bits(byte value)
        {
            return new Bits(value);
        }
        public override string ToString()
        {
            return "Bits value: " + this.value; 
        }

    }
}

