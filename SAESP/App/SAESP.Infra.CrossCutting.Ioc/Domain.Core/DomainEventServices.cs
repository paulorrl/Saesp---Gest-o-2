using Microsoft.Extensions.DependencyInjection;
using SAESP.Domain.Core.Commands;
using SAESP.Domain.Core.Notification;

namespace SAESP.Infra.CrossCutting.Ioc.Domain.Core
{
    public static class DomainEventServices
    {
        public static void Resolver(IServiceCollection container)
        {
            container.AddScoped<ICommandHandler<DomainNotification>, DomainNotificationHandler>();
        }
    }
}