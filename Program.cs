using System;
using System.Xml;

namespace XMLValuesInConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument document = new XmlDocument();
            document.Load("NumbersXml.xml");
            foreach (XmlNode item in document)
            {
                foreach (XmlNode item1 in item.ChildNodes)
                {
                    Console.Write(item1.InnerText);
                }
            }
            Console.Read();
        }
    }
}