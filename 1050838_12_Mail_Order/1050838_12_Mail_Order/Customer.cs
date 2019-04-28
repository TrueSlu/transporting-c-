using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1050838_12_Mail_Order
{
    public class Customer
    {
        public String Name { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public int ZipCode { get; set; }

        public Customer() { }

        public Customer(String n, String a, String c, String s, int z)
        {
            Name = n;
            Address = a;
            City = c;
            State = s;
            ZipCode = z;
        }
    }
}
