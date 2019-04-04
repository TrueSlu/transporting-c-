using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1050838_Lu_Pet_12._11
{
    public class Pet
    {
        public String Name { get; set; }
        public String Type { get; set; }
        public String Breed { get; set; }
        public String Color { get; set; }

        public Pet() { }
        public Pet(String n, String t, String b, String c)
        {
            Name = n;
            Type = t;
            Breed = b;
            Color = c;
        }
    }
}
