using SAESP.Domain.Core.Commands;
using System.Collections.Generic;

namespace SAESP.Domain.Core.Notification
{
    public class DomainNotificationHandler : ICommandHandler<DomainNotification>
    {
        private readonly List<DomainNotification> _notifications = new List<DomainNotification>();

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
    }
}