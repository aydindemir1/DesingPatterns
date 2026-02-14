// See https://aka.ms/new-console-template for more information
using BuilderPattern;

Console.WriteLine("Hello, World!");


var request = new ReportRequestBuilder()
            .ForPatient(123)
            .WithDateRange(DateTime.Today.AddDays(-7), DateTime.Today)
            .IncludeImages()
            .InLanguage("en")
            .InFormat("PDF")
            .Build();

Console.WriteLine(request);
Console.ReadLine();


var director = new ReportDirector();

var standard = director.CreateStandardReport(100);
var detailed = director.CreateDetailedReport(200);
var audit = director.CreateAuditReport(300);

Console.WriteLine("Standard:");
Console.WriteLine(standard);

Console.WriteLine("\nDetailed:");
Console.WriteLine(detailed);

Console.WriteLine("\nAudit:");
Console.WriteLine(audit);

Console.ReadLine();