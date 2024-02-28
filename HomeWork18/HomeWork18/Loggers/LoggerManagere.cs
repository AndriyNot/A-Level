namespace HomeWork18.Loggers
{
    public class LoggerManager
    {
        public static async Task LogEntriesAsync(Logger logger, int count)
        {
            for (int i = 0; i < count; i++)
            {
                string logEntry = $"Log entry {i + 1}";

                await logger.LogAsync(logEntry);
            }
        }

    }
}
