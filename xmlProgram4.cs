using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Serialization
{
    class xmlProgram4
    {
        public static void SerializeData()
        {
            FileStream fs = new FileStream(@"F:\serial\over5.txt", FileMode.Create);
            XmlSerializer xmlObj = new XmlSerializer(typeof(DateTime));
            xmlObj.Serialize(fs, System.DateTime.Now);
            fs.Close();
        }
        public static void DeSerializeData()
        {
            FileStream fs = new FileStream(@"F:\serial\over5.txt", FileMode.Open);
            XmlSerializer xs = new XmlSerializer(typeof(DateTime));
            DateTime time = (DateTime)xs.Deserialize(fs);
            fs.Close();
            Console.WriteLine("Day: " + time.DayOfWeek + ", Time: " + time.TimeOfDay.ToString() + ", Date: " + time.Date.ToShortDateString());
        }
        static void Main(string[] args)
        {
            SerializeData();
            DeSerializeData();
        }
    }
}