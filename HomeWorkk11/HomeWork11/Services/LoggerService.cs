using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace HomeWork11.Services
{
    public class LoggerService
    {
        private readonly ILogger<LoggerService> _logger;
        private readonly IConfiguration _configuration;

        public LoggerService(ILogger<LoggerService> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public void LogInformation(string message)
        {
            string logLevel = _configuration["Logger:Default:Information"];
            _logger.LogInformation($"Log Level from Config: {logLevel}");
        }
    }
}
