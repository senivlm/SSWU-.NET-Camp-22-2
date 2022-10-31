using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_Dovbyshchuk_Volodymyr
{
    internal class Storage
    {
        private Product[] products;

        public Product[] Products { get { return products; } }

        public Storage()
        {
            this.products = new Product[] { };

        }
        public Storage(Product[] products)
        {
            this.products = products;
        }

        public void AddProduct(Product product)
        {
            this.Products[Products.Length] = product;
            Array.Resize(ref this.products, Products.Length + 1);
        }

        public void ChangePrices(Product[] products, int percent)
        {
            foreach (Product product in products)
            {
                product.ChangePrice(percent);
            }
        }

        public Meat[] GetMeat()
        {
            Meat[] meatProducts = new Meat[] { };
            foreach (Product product in products)
            {
                if (product is Meat)
                {
                    meatProducts[meatProducts.Length] = (Meat)product;
                    Array.Resize(ref this.products, Products.Length + 1);
                }
            }
            return meatProducts;
        }

        public Product this[int index]
        {
            get { return products[index]; }
            set { products[index] = value; }
        }

        public override string ToString()
        {
            string res = String.Empty;
            foreach (Product product in products)
                res += product.ToString();
            return res;
        }
    }
}
