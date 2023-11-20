using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public class object_person

    {
        public string firstName;
        public string lastName;
        public int age;
        public string address;
        public string city;
        public string state;
        public string zipCode;
        public string country;


        public string getInfo(string separator)
        {
            string std_Profile = firstName +  separator  + lastName +  separator  + age + separator  + address + separator  + city + separator  + state + separator  + zipCode+  separator  + country;
            return std_Profile;

        }
      
    }

}