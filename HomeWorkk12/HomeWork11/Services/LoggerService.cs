using HomeWork11.Config;
using HomeWork11.Services.Abstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace HomeWork11.Services
{
    public class LoggerService : ILoggerService
    {
        public readonly LoggingSettings _loggingSettings;
        public LoggerService(IOptions<LoggingSettings> loggingSettings)
        {
           _loggingSettings = loggingSettings.Value;
        }

        public void Log(string message)
        {
            var log = $"{message}";
            Console.WriteLine(log);
            Debug.WriteLine($"write log to {_loggingSettings.Default}");
        }
        
    }
}
