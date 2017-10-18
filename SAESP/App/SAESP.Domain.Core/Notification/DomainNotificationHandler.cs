using SAESP.Domain.Core.Commands;
using System;
using System.Collections.Generic;

namespace SAESP.Domain.Core.Notification
{
    public class DomainNotificationHandler : ICommandHandler<DomainNotification>, IDisposable
    {
        private List<DomainNotification> _notifications;

        public DomainNotificationHandler()
        {
            _notifications = new List<DomainNotification>();
        }

        public ICommandResult Handle(DomainNotification command)
        {
            _notifications.Add(command); // Neste cenário, o parâmetro "command" corresponde à uma notification.
            return null;
        }

        public bool HasNotification()
        {
            return GetValue().Count > 0;
        }

        public IEnumerable<DomainNotification> Notify()
        {
            return GetValue();
        }

        private List<DomainNotification> GetValue()
        {
            return _notifications;
        }

        public void Dispose()
        {
            _notifications = new List<DomainNotification>();
        }
    }
}