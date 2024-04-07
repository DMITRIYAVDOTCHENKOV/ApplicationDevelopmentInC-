using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.seminar_7.hw
{
    internal class ObjectExtensions
    {
        public static string ObjectToString(object obj)
        {
            Type type = obj.GetType();
            BindingFlags flags = BindingFlags.Instance | BindingFlags.Public;

            string result = "";

            foreach (FieldInfo field in type.GetFields(flags))
            {
                CustomNameAttribute customNameAttribute = (CustomNameAttribute)Attribute.GetCustomAttribute(field, typeof(CustomNameAttribute));

                string fieldName = customNameAttribute != null ? customNameAttribute.CustomFieldName : field.Name;

                result += $"{fieldName}:{field.GetValue(obj)} ";
            }

            return result.Trim();
        }

        public static void StringToObject(object obj, string data)
        {
            string[] pairs = data.Split(' ');

            Type type = obj.GetType();
            BindingFlags flags = BindingFlags.Instance | BindingFlags.Public;

            foreach (string pair in pairs)
            {
                string[] keyValue = pair.Split(':');
                string fieldName = keyValue[0];
                string value = keyValue[1];

                FieldInfo field = type.GetField(fieldName, flags);

                if (field == null)
                {
                    field = type.GetFields(flags).FirstOrDefault(f =>
                    {
                        CustomNameAttribute customNameAttribute = (CustomNameAttribute)Attribute.GetCustomAttribute(f, typeof(CustomNameAttribute));
                        return customNameAttribute != null && customNameAttribute.CustomFieldName == fieldName;
                    });
                }

                if (field != null)
                {
                    object typedValue = Convert.ChangeType(value, field.FieldType);
                    field.SetValue(obj, typedValue);
                }
            }
        }
    }
}