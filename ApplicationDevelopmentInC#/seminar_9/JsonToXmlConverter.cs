using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;

namespace ApplicationDevelopmentInC_.seminar_9
{
    internal class JsonToXmlConverter
    {
        static void Main()
        {
            string json = "{\"name\": \"John\", \"age\": 30, \"city\": \"New York\"}";

            JsonDocument jsonDoc = JsonDocument.Parse(json);
            JsonElement root = jsonDoc.RootElement;

            XmlDocument xmlDoc = new XmlDocument();
            XmlNode xmlRoot = xmlDoc.CreateElement("Root");
            xmlDoc.AppendChild(xmlRoot);

            ConvertJsonToXml(root, xmlDoc, xmlRoot);

            Console.WriteLine(xmlDoc.InnerXml);
        }

        static void ConvertJsonToXml(JsonElement jsonElement, XmlDocument xmlDoc, XmlNode xmlNode)
        {
            foreach (var property in jsonElement.EnumerateObject())
            {
                XmlNode newNode = xmlDoc.CreateElement(property.Name);
                xmlNode.AppendChild(newNode);

                if (property.Value.ValueKind == JsonValueKind.Object)
                {
                    ConvertJsonToXml(property.Value, xmlDoc, newNode);
                }
                else
                {
                    newNode.InnerText = property.Value.ToString();
                }
            }
        }
    }
}