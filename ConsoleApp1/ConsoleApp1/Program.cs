using ConsoleApp1.Logging;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var loggerFactory = new DefaultLoggerFactory();
            var logger = loggerFactory.GetLogger();

            logger.Log("Hello World!");
        }
    }
}
