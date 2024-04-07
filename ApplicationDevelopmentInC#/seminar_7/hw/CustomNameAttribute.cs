using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.seminar_7.hw
{
    internal class CustomNameAttribute : Attribute
    {
        public string CustomFieldName { get; }

        public CustomNameAttribute(string customFieldName)
        {
            CustomFieldName = customFieldName;
        }
    }
    public class MyClass
    {
        [CustomName("CustomFieldName")]
        public int I = 0;
    }

}