using Homework_3_Dovbyshchuk_Volodymyr;

Meat meat = new Meat();

meat.Name = "Something";
meat.Weight = 100;
meat.Category = Category.HighestGrade;
meat.Price = 13.50;
meat.TypeOfMeat = TypeOfMeat.Mutton;

Console.WriteLine(meat);

Meat meat1 = new Meat("Anything", 120, 10, Category.FirstGrade, TypeOfMeat.Veal);

Console.WriteLine(meat1);

Console.WriteLine(meat.Equals(meat1));

Product product = new Product();
Product product1 = new Product();


Console.WriteLine(product.Equals(product1));

product1.Name = "apple";
product1.Weight = 100;
product1.Price = 12.4;

Console.WriteLine(product.Equals(product1));

Meat meat2 = new Meat();

meat2.Price = -3;

Console.WriteLine(meat2);


