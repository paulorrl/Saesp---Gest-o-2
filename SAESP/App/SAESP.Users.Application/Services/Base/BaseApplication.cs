using SAESP.Domain.Core;
using SAESP.Domain.Core.Notification;
using SAESP.Domain.Core.Services;
using SAESP.Infra.Data.Transactions;
using System;

namespace SAESP.Users.Application.Services.Base
{
    public class BaseApplication : ServiceNotification
    {
        private readonly IUow _uow;

        public BaseApplication(IUow uow)
        {
            _uow = uow;
        }

        public bool Commit()
        {
            if (HasNotification())
            {
                return false;
            }

            _uow.Commit();
            return true;
        }

        public void Rollback(string message)
        {
            DomainEvent.Raise<DomainNotification>(new DomainNotification("BusinessError", message));
            Rollback();
        }

        public void Rollback()
        {
            _uow.Rollback();
        }
    }
}