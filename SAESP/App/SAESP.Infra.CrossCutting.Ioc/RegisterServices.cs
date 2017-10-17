using Microsoft.Extensions.DependencyInjection;
using SAESP.Domain.Core;
using SAESP.Infra.CrossCutting.Ioc.Users;

namespace SAESP.Infra.CrossCutting.Ioc
{
    public static class RegisterServices
    {
        public static void Resolver(IServiceCollection container)
        {
            // Users
            UserDomainServices.Resolver(container);

            DomainEvent.Container = new DomainEventContainer(container); // Esta linha sempre em último (Testar no projeto IOC e na API)
        }
    }
}