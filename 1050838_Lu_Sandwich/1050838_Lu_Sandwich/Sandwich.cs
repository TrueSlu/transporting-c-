using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1050838_Lu_Sandwich
{
    public class Sandwich
    {
        public String Name { get; set; }
        public String Bread { get; set; }
        public String Meat { get; set; }
        public String Cheese { get; set; }
        public bool[] Condiments { get; set; }

        public Sandwich() { }

        public Sandwich(String n, String b, String m, String ch, bool[] co)
        {
            Name = n;
            Bread = b;
            Meat = m;
            Cheese = ch;
            Condiments = co;
        }
    }
}
