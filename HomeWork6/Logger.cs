using System;

public class Logger
{
	private static Logger instance;

	private Logger() 
	{ 
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
		string recordLog = $"{DateTime.Now}: {logType}: {message}";
        Console.Write(recordLog);
    }
}

public enum LoggerType
{
    Error, 
	Info, 
	Warning
}
