using Microsoft.Extensions.DependencyInjection;
using SAESP.Users.Domain.Commands.Handlers;
using SAESP.Users.Domain.Factories;

namespace SAESP.Infra.CrossCutting.Ioc.Modules.Users
{
    public static class UserDomainServices
    {
        public static void Resolver(IServiceCollection container)
        {
            container.AddTransient<UserCommandHandler, UserCommandHandler>();

            container.AddScoped<IUserFactory, UserFactory>();
        }
    }
}