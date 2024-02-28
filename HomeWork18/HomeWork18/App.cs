namespace HomeWork18
{
    using HomeWork18.BackupCreators;
    using HomeWork18.Loggers;

    public class App
    {
        public async Task Run()
        {
            string logFilePath = "log.txt";
            Logger logger = new Logger(logFilePath);

            logger.BackupRequired += () =>
            {
                List<string> logEntries = logger.GetLogEntries();
                BackupCreator.CreateBackup(logEntries, 10);
            };

            await LoggerManager.LogEntriesAsync(logger, 50);
            await LoggerManager.LogEntriesAsync(logger, 50);

            Console.WriteLine("All log entries created.");
        }
    }
}
