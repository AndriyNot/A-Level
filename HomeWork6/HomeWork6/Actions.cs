using System;

public class Actions
{
    public Result StartMethod()
    {
        Result result = new Result { Status = true };

        Console.ForegroundColor = ConsoleColor.Green;
        Logger.instance.LoggerWritesInformation(LoggerType.Info, "Start method");
        Console.ResetColor();

        return result;
    }

    public Result SkippedLogicInMethod()
    {
        Result result = new Result { Status = true };

        Console.ForegroundColor = ConsoleColor.Yellow;
        Logger.instance.LoggerWritesInformation(LoggerType.Warning, "Skipped logic in method");
        Console.ResetColor();

        return result;
    }

    public Result ActionFailedByReason()
    {
        Result result = new Result { Status = false, errorMessage = "I broke a logic" };

        return result;
    }
}
