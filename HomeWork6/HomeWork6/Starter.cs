using System;
using System.IO;

public class Starter
{
    public void Run()
    {
        Logger logger = Logger.Instance;
        Actions action = new Actions();
        Random rnd = new Random();
        Result result = new Result();

        for (int i = 0; i < 100; i++)
        {
            int randomMethod = rnd.Next(1, 4);

            switch (randomMethod)
            {
                case 1:

                    action.StartMethod();

                    break;

                case 2:

                    action.SkippedLogicInMethod();

                    break;

                case 3:

                    result = action.ActionFailedByReason();

                    if (result.Status == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Logger.instance.LoggerWritesInformation(LoggerType.Error, $"Action failed by a reason: {result.errorMessage}");
                        Console.ResetColor();
                    }

                    break;
            }
        }

        RequestToSaveLogs(logger);
    }

    public void RequestToSaveLogs(Logger logger)
    {
        Console.WriteLine("\nWrite logs to file?");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Yes - 1  |");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("  No - 2");

        Console.ResetColor();
        int user = Convert.ToInt32(Console.ReadLine());

        int indexYes = 1;
        int indexNo = 2;

        if (user == indexYes)
        {
            File.WriteAllText("log.txt", string.Join("\n", logger.GetLogsArray()));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Logs saved to file.");
        }

        if (user == indexNo)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Logs not saved to file.");
        }

        Console.ResetColor();
        Console.ReadKey();
    }

}
