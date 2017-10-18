using Microsoft.Extensions.DependencyInjection;
using SAESP.Infra.Data.Context;
using SAESP.Infra.Data.Repositories;
using SAESP.Infra.Data.Transactions;
using SAESP.Users.Domain.Repositories;

namespace SAESP.Infra.CrossCutting.Ioc.Data
{
    public static class DataServices
    {
        public static void Resolver(IServiceCollection container)
        {
            container.AddScoped<SaespContext, SaespContext>();
            container.AddScoped<IUow, Uow>();

            container.AddScoped<IUserRepository, UserRepository>();
        }
    }
}