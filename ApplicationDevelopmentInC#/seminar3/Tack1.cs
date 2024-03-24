using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.seminar3
{
    internal class Tack1
    {

class Program
    {
        static int[,] labirynth1 = new int[,]
        {
        {1, 1, 1, 1, 1, 1, 1 },
        {1, 0, 0, 0, 0, 0, 1 },
        {1, 0, 1, 1, 1, 0, 1 },
        {0, 0, 0, 0, 1, 0, 0 },
        {1, 1, 0, 0, 1, 1, 1 },
        {1, 1, 1, 0, 1, 1, 1 },
        {1, 1, 1, 0, 1, 1, 1 }
        };

        static int HasExit(int startI, int startJ, int[,] l)
        {
            if (l[startI, startJ] == 0)
            {
                if (startI == 0 || startI == l.GetLength(0) - 1 || startJ == 0 || startJ == l.GetLength(1) - 1)
                {
                    return 1;
                }
                l[startI, startJ] = 1;

                int result = 0;
                result += HasExit(startI - 1, startJ, l);
                result += HasExit(startI + 1, startJ, l);
                result += HasExit(startI, startJ - 1, l);
                result += HasExit(startI, startJ + 1, l);

                return result;
            }

            return 0;
        }

/*        static void Main()
        {
            int startI = 1;
            int startJ = 1;
            int exits = HasExit(startI, startJ, labirynth1);
            Console.WriteLine("Количество выходов из лабиринта: " + exits);
        }*/
    }

}
}
