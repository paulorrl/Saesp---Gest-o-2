using System;
using System.Collections.Generic;
using SAESP.Domain.Core.Container;
using Microsoft.Extensions.DependencyInjection;

namespace SAESP.Infra.CrossCutting.Ioc.Domain.Core
{
    public class DomainEventContainer : IContainer
    {
        private readonly IServiceProvider _provider;

        public DomainEventContainer(IServiceCollection services)
        {
            _provider = services.BuildServiceProvider();
        }

        public T GetService<T>()
        {
            return (T) _provider.GetService<T>();
        }

        public object GetService(Type serviceType)
        {
            return _provider.GetService(serviceType);
        }

        public IEnumerable<T> GetServices<T>()
        {
            return (IEnumerable<T>) _provider.GetService<T>();
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _provider.GetServices(serviceType);
        }
    }
}