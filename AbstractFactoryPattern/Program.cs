// See https://aka.ms/new-console-template for more information
using AbstractFactoryPattern;

Console.WriteLine("Hello, World!");



Console.Write("Format (PDF/Excel): ");
string format = Console.ReadLine();

IReportFactory factory = format switch
{
    "PDF" => new PdfReportFactory(),
    "Excel" => new ExcelReportFactory(),
    _ => throw new ArgumentException("Unknown format")
};

var service = new ReportService(factory);
service.CreateAndSaveReport("sales-data-2026");

Console.ReadLine();