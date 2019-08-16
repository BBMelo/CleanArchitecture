using FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;
using vxTel.Domain.Interfaces;

namespace vxTel.Domain.Notifications
{
    public sealed class Notification 
    {
        private readonly List<NotificationBase> _notifications;
        public IReadOnlyCollection<NotificationBase> Notifications { get { return _notifications; } }
        public bool HasNotifications { get { return _notifications.Any(); } }

        public Notification() => _notifications = new List<NotificationBase>();

        public void AddNotification(string key, string message) => _notifications.Add(new NotificationBase(key, message));
        public void AddNotification(NotificationBase notification) => _notifications.Add(notification);
        public void AddNotifications(IEnumerable<NotificationBase> notifications) => _notifications.AddRange(notifications);
        public void AddNotifications(IReadOnlyCollection<NotificationBase> notifications) => _notifications.AddRange(notifications);
        public void AddNotifications(IList<NotificationBase> notifications) => _notifications.AddRange(notifications);
        public void AddNotifications(ICollection<NotificationBase> notifications) => _notifications.AddRange(notifications);
        public void AddNotifications(ValidationResult validationResult) => validationResult.Errors?.ToList().ForEach(f => { AddNotification(f.ErrorCode, f.ErrorMessage); });

        public void Add(string message)
        {
            AddNotification(new NotificationBase(string.Empty, message));
        }
    }

    public sealed class NotificationBase
    {
        public string Key { get; }
        public string Message { get; }

        public NotificationBase(string key, string message)
        {
            Key = key;
            Message = message;
        }
    }

}
