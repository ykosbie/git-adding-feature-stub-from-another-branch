namespace ConsoleApp1.Logging
{
    public class NullLogger : ILogger
    {
        public void Log(string message)
        {
            //nop
        }
    }
}
