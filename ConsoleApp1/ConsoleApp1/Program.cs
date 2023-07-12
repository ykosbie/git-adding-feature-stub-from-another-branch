using ConsoleApp1.Logging;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var loggerFactory = new DefaultLoggerFactory();
            var logger = loggerFactory.GetLogger();

            Console.Write("Name> ");
            var name = Console.ReadLine();

            logger.Log($"Hello {name}!");
        }
    }
}
