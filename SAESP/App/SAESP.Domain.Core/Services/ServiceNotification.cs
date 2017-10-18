using SAESP.Domain.Core.Commands;
using SAESP.Domain.Core.Notification;
using System;
using System.Collections.Generic;

namespace SAESP.Domain.Core.Services
{
    public class ServiceNotification : IDisposable
    {
        private DomainNotificationHandler _notifications;

        public ServiceNotification()
        {
            _notifications = (DomainNotificationHandler) DomainEvent.Container.GetService< ICommandHandler<DomainNotification> > ();
        }

        public bool HasNotification()
        {
            return _notifications.HasNotification();
        }

        public void AddNotification(DomainNotification notification)
        {
            _notifications.Handle(notification);
        }

        public IEnumerable<DomainNotification> GetNotifications()
        {
            return _notifications.Notify();
        }

        public void Dispose()
        {
            _notifications.Dispose();
        }
    }
}