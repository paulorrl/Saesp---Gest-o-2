using SAESP.Domain.Core.Notification;
using System.Collections.Generic;
using System.Linq;

namespace SAESP.Domain.Core.Validation
{
    public static class AssertionConcern
    {
        //TODO: Inserir mais métodos genéricos de validações!

        public static bool IsSatisfiedBy(params DomainNotification[] notifications)
        {
            IEnumerable<DomainNotification> __notifications = from notify in notifications
                                                             where notify != null
                                                             select notify;

            NotifyAll(__notifications);
            return __notifications.Count<DomainNotification>().Equals(0);
        }

        private static void NotifyAll(IEnumerable<DomainNotification> notifications)
        {
            notifications
                .ToList<DomainNotification>()
                .ForEach(notify => DomainEvent.Raise<DomainNotification>(notify));
        }
    }
}