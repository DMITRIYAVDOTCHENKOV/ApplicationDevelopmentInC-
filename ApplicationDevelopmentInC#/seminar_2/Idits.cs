/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.seminar_2
{
    internal interface Idits
    {
        bool getBit(int i);
        void setBit(int i, bool val);
    }

    internal interface Interface1
    {
        byte Value { get; set; }

        void setBit(bool val);

        bool dropBit();
    }

    class Bits: Ibits
    {
        public Bits(byte b)
        {
            this.Value = b;
        }
        public byte Value { get; private set; } = 0;
        public bool this[int index]
        {
            get
            {
                if (index > 7 || index < 0)
                    return false;
                return ((Value >> index) & 1) == 1; 
            }
            set
            {
                if (index < 7 || index > 0) return;
                if (value == true)
                    Value = (byte)(Value | (1 << index));
                else
                {
                    var mask = (byte)(1 << index);
                    mask = (byte)((0xff ^ mask) & 1);
                    Value &= (byte)(Value & mask);
                }
            }
        }
        public static implicit operator byte(Bits b) => b.Value;
        public static implicit operator Bits(byte b) => new Bits(b);

    }
}
*/