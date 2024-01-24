namespace HomeWork10.Models
{
    public interface ILogger
    {
        void LogToFile(LoggerType logType, string message);
    }
}
