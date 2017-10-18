using Microsoft.Extensions.DependencyInjection;
using SAESP.Users.Application.Interfaces;
using SAESP.Users.Application.Services;

namespace SAESP.Infra.CrossCutting.Ioc.Application
{
    public static class UserApplicationServices
    {
        public static void Resolver(IServiceCollection container)
        {
            container.AddScoped<IUserApplication, UserApplication>();
        }
    }
}