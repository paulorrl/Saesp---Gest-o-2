using SAESP.Domain.Core.Commands;
using SAESP.Domain.Core.Notification;

namespace SAESP.Domain.Core.Services
{
    public abstract class ServiceNotification
    {
        private readonly DomainNotificationHandler _notifications;

        protected ServiceNotification()
        {
            _notifications = (DomainNotificationHandler) DomainEvent.Container.GetService< ICommandHandler<DomainNotification> > ();
        }

        protected bool HasNotifications()
        {
            return _notifications.HasNotification();
        }

        protected void AddNotification(DomainNotification notification)
        {
            _notifications.Handle(notification);
        }
    }
}