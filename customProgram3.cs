using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Serialization
{
    [Serializable]
    class customProgram3
    {
        public int EmpID;
        public string EmpName;
        public string Address;
        public customProgram3(int id, string name, string EmpAdd)
        {
            EmpID = id;
            EmpName = name;
            Address = EmpAdd;
        }
    }
    class Program3
    {
        public static void SerializeData()
        {
            customProgram3 obj = new customProgram3(1, "Raj", "bangalore");
            FileStream fs = new FileStream(@"F:\\serial\\over3.txt", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, obj);
            fs.Close();
        }
        public static void DeSerializeData()
        {
            customProgram3 emp;
            FileStream fs = new FileStream(@"F:\\serial\\over3.txt", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();              
            emp = (customProgram3)bf.Deserialize(fs);
            int id = emp.EmpID;
            string name = emp.EmpName;
            string Empadd = emp.Address;
            fs.Close();
            Console.WriteLine("Your deserialize data is ");
            Console.WriteLine("EmpID = " + id);
            Console.WriteLine("Emp Name = " + name);
            Console.WriteLine("Emp Address = " + Empadd);
        }
        static void Main(string[] args)
        {
            SerializeData();
            DeSerializeData();
            Console.ReadLine();
        }
    }
}
