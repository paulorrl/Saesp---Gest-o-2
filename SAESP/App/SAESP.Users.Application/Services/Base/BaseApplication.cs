using SAESP.Domain.Core;
using SAESP.Domain.Core.Notification;
using SAESP.Domain.Core.Services;
using SAESP.Infra.Data.Transactions;

namespace SAESP.Users.Application.Services.Base
{
    public abstract class BaseApplication : ServiceNotification
    {
        private readonly IUow _uow;

        protected BaseApplication(IUow uow)
        {
            _uow = uow;
        }

        internal bool Commit()
        {
            if (HasNotifications())
            {
                return false;
            }

            _uow.Commit();
            return true;
        }

        internal void Rollback(string message)
        {
            DomainEvent.Raise<DomainNotification>(new DomainNotification("BusinessError", message));
            Rollback();
        }

        internal void Rollback()
        {
            _uow.Rollback();
        }
    }
}