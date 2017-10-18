using Microsoft.Extensions.DependencyInjection;
using SAESP.Domain.Core;
using SAESP.Infra.CrossCutting.Ioc.Data;
using SAESP.Infra.CrossCutting.Ioc.Domain.Core;
using SAESP.Infra.CrossCutting.Ioc.Modules.Users;

namespace SAESP.Infra.CrossCutting.Ioc
{
    public static class RegisterServices
    {
        public static void Resolver(IServiceCollection container)
        {
            // Domain Core (SharedKernel)
            DomainEventServices.Resolver(container);

            // Infra.Data
            DataServices.Resolver(container);

            // Users
            UserDomainServices.Resolver(container);

            // Esta linha sempre em último (Testar no projeto IOC e na API)
            DomainEvent.Container = new DomainEventContainer(container);
        }
    }
}