using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{     
    public class DeserializeExample
    {
        public static void Main(string[] args)
        {
            FileStream stream = new FileStream("F:\\serial\\over6.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            simpleBynary s = (simpleBynary)formatter.Deserialize(stream);
            Console.WriteLine("Rollno: " + s.rollno);
            Console.WriteLine("Name: " + s.name);

            stream.Close();
        }
    }
}
