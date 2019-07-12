using System;
using System.Xml.Linq;

namespace Labs_92_XML_Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nHello World First Element\n----------------------------------------------");
            var xml01 = new XElement("testElement", 100);
            Console.WriteLine(xml01);

            Console.WriteLine("\n\nHello World Sub Element\n----------------------------------------------");
            var xml02 = new XElement("testElement", new XElement("subElement", 200));
            Console.WriteLine(xml02);

            Console.WriteLine("\n\nWe can now add multiple elements\n----------------------------------------------");
            var xml03 = new XElement("testElement", new XElement("subElement", 200),
                new XElement("subElement", 200),
                new XElement("subElement", 200),
                new XElement("subElement", 200),
                new XElement("subElement", 200),
                new XElement("subElement", 200)
                );
            Console.WriteLine(xml03);

            Console.WriteLine("\n\nWe can now add multiple elements\n----------------------------------------------");
            var xml04 = new XElement("testElement",
                new XElement("subElement",
                new XAttribute("width", 200),
                new XElement("AnotherElement",100),
                new XElement("Lastone",600)
                
                ),
                new XElement("subElement",
                new XAttribute("width", 200), 300),
                new XElement("subElement",
                new XAttribute("width", 200), 300),
                new XElement("subElement",
                new XAttribute("width", 200), 300),
                new XElement("subElement",
                new XAttribute("width", 200), 300)
                );
        
            Console.WriteLine(xml04);
        }
    }
}
