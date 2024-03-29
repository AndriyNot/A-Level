using HomeWork4._5.Models;
using HomeWork4._5.Service.Abstractions;
using Microsoft.Extensions.Logging;


namespace HomeWork4._5.Service
{
    public class NotificationService : INotificationService
    {
        private readonly ILogger<NotificationService> _loggerService;

        public NotificationService(ILogger<NotificationService> loggerService)
        {
            _loggerService = loggerService;
        }

        public void Notify(NotifyType type, string massage, string to)
        {
            
            _loggerService.LogInformation($"Notification was sent for type {type}");
        }
    }
}
