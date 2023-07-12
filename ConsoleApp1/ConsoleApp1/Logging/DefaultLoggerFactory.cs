namespace ConsoleApp1.Logging
{
    public class DefaultLoggerFactory : ILoggerFactory
    {
        public ILogger GetLogger()
        {
            return new ConsoleLogger();
        }
    }
}
