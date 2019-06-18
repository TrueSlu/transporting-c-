using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1050838_Lu_11._5
{
    public class Person
    {
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string CellNo { get; set; }
        public string VoicemailNo { get; set; }
        public string PagerNo { get; set; }
        public string Email { get; set; }
        public Person(string n, string ph, string c, string v, string pa, string e)
        {
            Name = n;
            PhoneNo = ph;
            CellNo = c;
            VoicemailNo = v;
            PagerNo = pa;
            Email = e;
        }
    }
}
