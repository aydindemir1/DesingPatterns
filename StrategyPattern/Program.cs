// See https://aka.ms/new-console-template for more information
using StrategyPattern;

Console.WriteLine("Hello, World!");

decimal price = 1000;

IDiscountStrategy strategy = new VipDiscountStrategy();
DiscountCalculator calculator = new DiscountCalculator(strategy);

decimal discount = calculator.CalculateDiscount(price);

Console.WriteLine($"İndirim: {discount} TL");
Console.ReadLine();


Console.Write("Kullanıcı Tipi (Student/Vip): ");
string userType = Console.ReadLine();

decimal price1 = 1000;

var resolver = new DiscountStrategyResolver();
IDiscountStrategy strategy1 = resolver.Resolve(userType);

var calculator1 = new DiscountCalculator(strategy1);
decimal discount1 = calculator1.CalculateDiscount(price1);

Console.WriteLine($"İndirim Tutarı: {discount1} TL");
Console.ReadLine();