using Microsoft.Extensions.DependencyInjection;
using SAESP.Users.Domain.Commands.Handlers;

namespace SAESP.Infra.CrossCutting.Ioc.Users
{
    public static class UserDomainServices
    {
        public static void Resolver(IServiceCollection container)
        {
            container.AddTransient<UserCommandHandler, UserCommandHandler>();
        }
    }
}