using Microsoft.Extensions.DependencyInjection;
using SAESP.Domain.Core.Commands;
using SAESP.Domain.Core.Notification;
using SAESP.Domain.Core.Services;

namespace SAESP.Infra.CrossCutting.Ioc.Domain.Core
{
    public static class DomainEventServices
    {
        public static void Resolver(IServiceCollection container)
        {
            container.AddScoped<ICommandHandler<DomainNotification>, DomainNotificationHandler>();
            container.AddScoped<ServiceNotification, ServiceNotification>();
        }
    }
}