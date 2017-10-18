using SAESP.Domain.Core.Notification;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SAESP.Domain.Core.Validation
{
    public static class AssertionConcern
    {
        public static DomainNotification IsEmail(string email, string property, string message)
        {
            return AssertIsEmail(email)
                ? null
                : new DomainNotification(property, message);
        }

        public static DomainNotification AssertArgumentGreater(decimal valueReference, decimal valueCompare, string property, string message)
        {
            return (valueReference > valueCompare)
                ? null
                : new DomainNotification(property, message);
        }

        public static DomainNotification AssertMinLength(string value, int min, string property, string message)
        {
            return (value.Length >= min)
                        ? null
                        : new DomainNotification(property, message);
        }

        public static DomainNotification AssertArgumentRangeNumeric(int value, int min, int max, string property, string message)
        {
            if (value >= min && value <= max)
                return null;

            return new DomainNotification(property, message);
        }

        public static DomainNotification AssertArgumentEquals(object object1, object object2, string property, string message)
        {
            if (object1.Equals(object2))
                return null;

            return new DomainNotification(property, message);
        }

        public static DomainNotification AssertArgumentNotEmpty(string stringValue, string property, string message)
        {
            if (!string.IsNullOrEmpty(stringValue))
                return null;

            return new DomainNotification(property, message);
        }

        public static DomainNotification AssertArgumentLength(string stringValue, int minimum, int maximum, string property, string message)
        {
            var notification = AssertArgumentNotEmpty(stringValue, property, message);
            if (notification != null)
                return notification;

            int length = stringValue.Trim().Length;
            if (length < minimum || length > maximum)
                return new DomainNotification(property, message);

            return null;
        }

        public static DomainNotification AssertArgumentNotNull(object objValue, string property, string message)
        {
            if (objValue != null)
                return null;

            return new DomainNotification(property, message);
        }

        public static DomainNotification AssertArgumentNull(object objValue, string property, string message)
        {
            if (objValue == null)
                return null;

            return new DomainNotification(property, message);
        }

        public static bool IsSatisfiedBy(params DomainNotification[] notifications)
        {
            IEnumerable<DomainNotification> __notifications = from notify in notifications
                                                              where notify != null
                                                              select notify;

            NotifyAll(__notifications);

            var testeBool = __notifications.Count<DomainNotification>().Equals(0);
            return testeBool;
        }

        private static void NotifyAll(IEnumerable<DomainNotification> notifications)
        {
            notifications
                .ToList<DomainNotification>()
                .ForEach(notify => DomainEvent.Raise<DomainNotification>(notify));
        }

        private static bool AssertIsEmail(string email)
        {
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }
    }
}