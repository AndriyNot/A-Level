using HomeWork4._5.Models;

namespace HomeWork4._5.Service.Abstractions
{
    public interface INotificationService
    {
        void Notify(NotifyType type, string massage, string to);
    }
}
