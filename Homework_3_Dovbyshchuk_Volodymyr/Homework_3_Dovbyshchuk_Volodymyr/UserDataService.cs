using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_Dovbyshchuk_Volodymyr
{
    internal class UserDataService
    {
        public static void EnterDataProduct(out string nameOfProduct, out double priceOfProduct, out double weightOfProduct)
        {
            Console.WriteLine("Введіть продукт який хочете додати: " + "\n");
            nameOfProduct = Console.ReadLine();
            Console.WriteLine("Введіть ціну продукту який хочете додати: " + "\n");
            double.TryParse(Console.ReadLine(), out priceOfProduct);
            Console.WriteLine("Введіть вагу продукту який хочете додати: " + "\n");
            double.TryParse(Console.ReadLine(), out weightOfProduct);
        }
        public static void EnterDataDairyProduct(out string nameOfProduct, out double priceOfProduct, out double weightOfProduct, out int suavilityPeriod)
        {

            EnterDataProduct(out nameOfProduct, out priceOfProduct, out weightOfProduct);
            Console.WriteLine("Введіть термін придатності в днях який хочете додати: " + "\n");
            int.TryParse(Console.ReadLine(), out suavilityPeriod);
        }
        public static void EnterDataDairyMeatProduct(out string nameOfProduct, out double priceOfProduct, out double weightOfProduct, out Category category, out TypeOfMeat typeOfMeat)
        {
            EnterDataProduct(out nameOfProduct, out priceOfProduct, out weightOfProduct);
            Console.WriteLine("Введіть категорію м'яса якого хочете додати: " + "\n");
            Enum.TryParse(Console.ReadLine(), out category);
            Console.WriteLine("Введіть вид м'яса який хочете додати: " + "\n");
            Enum.TryParse(Console.ReadLine(), out typeOfMeat);
        }
    }
}
