using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    [Serializable]
    class program1
    {
        public int ID;
        public String Name;
        static void Main(string[] args)
        {
            program1 obj = new program1();
            obj.ID = 1;
            obj.Name = ".Net";

            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("F:\\serial\\over.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, obj);
            stream.Close();

            //stream = new FileStream("F:\\serial\\over.txt", FileMode.Open, FileAccess.Read);
            //program1 objnew = (program1)formatter.Deserialize(stream);

            //Console.WriteLine(objnew.ID);
            //Console.WriteLine(objnew.Name);
        }
    }
}
