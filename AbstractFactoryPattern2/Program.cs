// See https://aka.ms/new-console-template for more information
using AbstractFactoryPattern2;

Console.WriteLine("Hello, World!");


Console.Write("Storage Type (Local/Cloud): ");
var type = Console.ReadLine();

IStorageFactory factory = type switch
{
    "Local" => new LocalStorageFactory(),
    "Cloud" => new CloudStorageFactory(),
    _ => throw new ArgumentException("Unknown storage type")
};

var service = new StorageService(factory);
service.ProcessFile("report.pdf");

Console.ReadLine();
