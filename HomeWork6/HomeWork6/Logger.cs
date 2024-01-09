using System;

public class Logger
{
    public static Logger instance;
    public string[] logsArray;
    public int currentIndex;

    private Logger()
    {
        int numberArray = 100;
        logsArray = new string[numberArray];
    }

    public static Logger Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Logger();
			}
			return instance;
		}
	}

	public void LoggerWritesInformation(LoggerType logType, string message)
    {
        string recordLog = $"{DateTime.Now}: {logType}: {message}\n";
        Console.Write(recordLog);

        logsArray[currentIndex] = recordLog;
        currentIndex++;
    }

    public string[] GetLogsArray()
    {
        return logsArray;
    }
}

public enum LoggerType
{
    Error, 
	Info, 
	Warning
}
