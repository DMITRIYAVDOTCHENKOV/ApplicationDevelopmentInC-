using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.lecture_1
{
    internal class SomeClass
    {
        public SomeClass(int someProperty)
        {
            SomeProperty = someProperty;
        }
        public int SomeProperty { get; init; }
        public int SomeProperty1 { get; init; } = 20;
        public int SomeProperty2 { get; set; }
    }
}
