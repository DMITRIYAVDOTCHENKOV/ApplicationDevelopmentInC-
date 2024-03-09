using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.lecture_1
{
    internal class StringUtils
    {
        public static string Reverse(string s)
        {
            return new String(s.ToCharArray().Reverse().ToArray());
        }
    }
}
