namespace HomeWork10.Models
{
    using System;

    public class Logger: ILogger
    {
        public string[] logsArray;
        public int currentIndex;

        public Logger()
        {
            int numberArray = 100;
            logsArray = new string[numberArray];
            currentIndex = 0;
        }

        public void LogToFile(LoggerType logType, string message) 
        {
            string recordLog = $"{DateTime.Now}: {logType}: {message}";
            Console.WriteLine(recordLog);

            logsArray[currentIndex] = recordLog;
            currentIndex++;
        }

        public string[] GetLogsArray()
        {
            return logsArray;
        }
    }
}
