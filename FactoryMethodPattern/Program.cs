// See https://aka.ms/new-console-template for more information
using FactoryMethodPattern;

Console.WriteLine("Hello, World!");


LoggerCreator logger = new FileLoggerCreator();
logger.Log("Sistem başladı");

LoggerCreator logger2 = new DbLoggerCreator();
logger2.Log("Kullanıcı giriş yaptı");

Console.ReadLine();