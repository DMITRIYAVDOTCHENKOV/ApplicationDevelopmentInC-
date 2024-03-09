using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.lecture_1
{
    internal class Age
    {
        private int age;

        public int AdultAge
        {
            get { return age; }
            set
            {
                if (value < 18)
                {
                    age = 18;
                }
                else
                    age = value;
            }
        }
    }
}