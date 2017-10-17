using SAESP.Domain.Core.Commands;

namespace SAESP.Domain.Core.Notification
{
    public class DomainNotification : ICommand
    {
        public string Property { get; private set; }
        public string Message { get; private set; }

        public DomainNotification(string property, string message)
        {
            this.Property = property;
            this.Message = message;
        }
    }
}