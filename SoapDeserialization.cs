using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace Serialization
{
    class SoapDeserialization
    {
        static void Main(string[] args)
        {
            FileStream stream1 = new FileStream(@"F:\serial\over7.xml", FileMode.OpenOrCreate);
            SoapFormatter fr = new SoapFormatter();
            College zz = (College)fr.Deserialize(stream1);
            Console.WriteLine("deserilization is");
            Console.WriteLine("college code is:" +zz. code);
            Console.WriteLine("college name is :" + zz.name);
            Console.WriteLine("college address is:" + zz.address);
            Console.WriteLine("year of joining is:" + zz.year);
        }

    }
}
