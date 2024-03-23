using ApplicationDevelopmentInC_.lecture_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.lecture_2
{
    internal interface IParent
    {
        public bool GetChildren(out Person[] childre);
        public void TakeCare();
    }
}
