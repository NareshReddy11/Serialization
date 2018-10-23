using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace Serialization
{
    [Serializable]
    class SoapSerialization
    {
        static void Main(string[] args)
        {
            College cl = new College(007, "SVCE", "Tiripati", 2005);
            SoapFormatter sf = new SoapFormatter();
            FileStream fs = new FileStream(@"F:\\serial\over8.txt", FileMode.Create, FileAccess.Write);
            sf.Serialize(fs, cl);
            fs.Close();
            Console.WriteLine("Soap Serialization is Successfully Done");
        }
    }
}
