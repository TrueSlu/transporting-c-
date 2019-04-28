using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1050838_12_Mail_Order
{
    public class Item
    {
        Customer Customer { get; set; }
        public String Description { get; set; }
        public float Quantity { get; set; }
        public float Weight { get; set; }
        public float Price { get; set; }
        public float HandlingPrice { get; set; }
        public float Tax { get; set; }
        const float TAX_RATE = 0.09f;


        public Item() { }
        public Item(String d, int q, float w, float p)
        {
            Description = d;
            Quantity = q;
            Weight = w;
            Price = p;
        }

        public float calculateShippingAndHandling(float weight)
        {
            if (weight < 10.0)
            {
                HandlingPrice = 1;
            }
            else if (weight > 10 && weight < 100)
            {
                HandlingPrice = 3;
            }
            else
            {
                HandlingPrice = 5;
            }
            return HandlingPrice;
        }
        public float calculateSalesTax(float price)
        {
            Tax = price * TAX_RATE;
            return Tax;
        }
        public void addCustomer(Customer c)
        {
            Customer = c;
        }
    }
}
