using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    class Program2
    {
        public static void SerializeData()
        {
            string str = "Welcome at biz runtime.";
            FileStream fs = new FileStream("F:\\serial\\over2.txt", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, str);
            fs.Close();
        }
        public static void DeSerializeData()
        {
            FileStream fs = new FileStream("F:\\serial\\over2.txt", FileMode.Open);  
            BinaryFormatter bf = new BinaryFormatter();
            string data = "";
            data = (string)bf.Deserialize(fs);
            fs.Close();
            Console.WriteLine("Your deserialize data is ");
            Console.WriteLine(data);
        }
        static void Main(string[] args)
        {
            SerializeData();
            DeSerializeData();
            Console.ReadLine();
        }
    }
}
