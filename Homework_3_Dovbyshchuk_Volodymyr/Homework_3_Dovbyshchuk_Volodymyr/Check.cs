using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_Dovbyshchuk_Volodymyr
{
    internal class Check
    {
        public static void DisplayProduct(Product product)
        {
            Console.WriteLine(product.ToString());
        }

        public static void DisplayBuy(Buy buy)
        {
            Console.WriteLine(buy.ToString());
        }

        public override string? ToString()
        {

            return "This method was redefined by me";
        }
    }
}
