using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1050838_Lu_11._2
{
    class Employee
    {
        public string Name { get; set; }
        public int Phone { get; set; }
        public float Rate { get; set; }

        const float OVERTIME_MULT = 1.5f;
        const int WORKWEEK = 40;

        public Employee(string n, int p, float r)
        {
            Name = n;
            Phone = p;
            Rate = r;
        }

        public float CalculatePay(int hours)
        {
            if (hours > WORKWEEK)
            {
                int overtime = hours - WORKWEEK;

                float overpay = overtime * Rate * OVERTIME_MULT;
                return (hours * Rate) + overtime;
            }
            else
            {
                return hours * Rate;
            }
        }
    }
}
