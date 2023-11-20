using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object_01
{
    public class person1
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public string profession;
        public string address;
        public string city;
        public string country;
        public int postalCode;

        public string getInfo(string separator)
        {
            string personInfo=firstName+separator+middleName+
                              separator+lastName+separator+profession+
                              separator+address+separator+city+separator+
                               country+separator+postalCode;
            return personInfo;
        }
    }
}
