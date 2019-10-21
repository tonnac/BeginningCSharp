using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace LINQtoXML
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string txt = @"
<people>
    <person name = 'anders' age = '47' />
    <person name = 'winnie' age = '13' />
</people>
";
            StringReader sr = new StringReader(txt);

            var xml = XElement.Load(sr);

            var query = from person in xml.Elements("person") select person;

            Array.ForEach(query.ToArray(), elem => Console.WriteLine(string.Format("{0}: {1}", elem.Attribute("name").Value, elem.Attribute("age").Value)));
        }
    }
}