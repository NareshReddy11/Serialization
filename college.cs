using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    class College
    {
        public int code;
        public string name;
        public string address;
        public int year;
        public College(int ss,string kk,string ll,int mm)
        {
            this.code = ss;
            this.name = kk;
            this.address = ll;
            this.year = mm;
        }
    }
}
