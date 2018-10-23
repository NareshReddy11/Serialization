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
    class simpleBynary
    {
       public int rollno;
       public string name;
       public simpleBynary(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }
    public class SerializeExample
    {
        public static void Main(string[] args)
        {
            FileStream stream = new FileStream("F:\\serial\\over6.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            simpleBynary s= new simpleBynary(101, "naresh");
            formatter.Serialize(stream, s);

            stream.Close();
        }
    }
}
