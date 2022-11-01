using Homework_1_Dovbyshchuk_Volodymyr;
// Вітаю. все доступно і правильно організовано.

Product apple = new Product("apple", 13.42, 13.50);

Console.WriteLine(apple);

Product carrot = new Product();

carrot.Name = "carrot";
carrot.Price = 13.76;
carrot.Weight = 13;

Console.WriteLine(carrot);

Product cucumber = new Product();

Console.WriteLine(cucumber);

Buy buyapple = new Buy(apple, 10);

Console.WriteLine(buyapple);

Buy buycarrot = new Buy();

buycarrot.Product = carrot;
buycarrot.Quantity = 10;

Console.WriteLine(buycarrot);

Buy buycucumber = new Buy();

Console.WriteLine(buycucumber);

Check.DisplayBuy(buyapple);

Check.DisplayProduct(cucumber);
