using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringTest
{
    public class Receipt
    {
        private int quantity;
        private string product;
        private decimal price;

        public Receipt(int quantity, string product, decimal price)
        {
            this.quantity = quantity;
            this.product = product;
            this.price = price;
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string Product
        {
            get { return product; }
            set { product = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
