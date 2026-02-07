// See https://aka.ms/new-console-template for more information
using StrategyPattern2;

Console.WriteLine("Hello, World!");


Console.Write("Kullanıcı Tipi (Student/Vip): ");
string userType = Console.ReadLine();

var strategies = new List<IDiscountStrategy>
        {
            new StudentDiscountStrategy(),
            new VipDiscountStrategy(),
            new NoDiscountStrategy()
        };

IDiscountStrategyFactory factory =
    new DiscountStrategyFactory(strategies);

var strategy = factory.Create(userType);
var calculator = new DiscountCalculator(strategy);

decimal discount = calculator.Calculate(1000);

Console.WriteLine($"İndirim: {discount} TL");
Console.ReadLine();