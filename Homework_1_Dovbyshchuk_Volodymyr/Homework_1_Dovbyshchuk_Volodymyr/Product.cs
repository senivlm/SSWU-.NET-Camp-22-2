using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_Dovbyshchuk_Volodymyr
{
    internal class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }
        public double Weight { get; set; }


        public Product()
        {
            Name = string.Empty;
            Price = 0.0;
            Weight = 0.0;
        }

        public Product(string name, double price, double weight)
        {
            this.Name = name;
            this.Price = price;
            this.Weight = weight;
        }

        public override string? ToString()
        {
            string res = "name: " + Name + "\n" + "price: " + Price + "\n" + "weight: " + Weight + "\n";

            return res;
        }

    }
}
