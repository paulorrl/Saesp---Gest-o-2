using SAESP.Domain.Core.Commands;
using SAESP.Domain.Core.Container;

namespace SAESP.Domain.Core
{
    public static class DomainEvent
    {
        public static IContainer Container { get; set; }

        public static void Raise<T>(T evento) where T : ICommand
        {
            ( (ICommandHandler<T>) Container.GetService( typeof(ICommandHandler<T>) ) ).Handle(evento); 
        }
    }
}