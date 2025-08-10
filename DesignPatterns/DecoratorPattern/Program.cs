using DecoratorPattern;

Beverage beverage = new Espresso();
beverage = new Milk(beverage);
beverage = new Mocha(beverage);
beverage = new Soy(beverage);
beverage = new Whip(beverage);
Console.WriteLine($"{beverage.GetDescription()} costs {beverage.GetCost():C2}");