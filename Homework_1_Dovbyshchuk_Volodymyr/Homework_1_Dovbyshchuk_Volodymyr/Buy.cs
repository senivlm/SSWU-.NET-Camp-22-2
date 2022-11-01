using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_Dovbyshchuk_Volodymyr
{
    internal class Buy
    {// покупка може містити більше одного товару.Це не враховано.
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public double TotalToPay { get { return Quantity * Product.Price; } }
        public Buy()
        {
            this.Product = new Product();
            this.Quantity = 0;
        }

        public Buy(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }

        public override string? ToString()
        {
            string res = "Product:\n" + Product.ToString() + "Quantity: " + Quantity + "\n" + "Total to pay: " + TotalToPay + "\n";
            return res;
        }
    }
}
