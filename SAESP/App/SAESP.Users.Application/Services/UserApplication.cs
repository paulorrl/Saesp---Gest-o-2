using SAESP.Domain.Core.Commands;
using SAESP.Infra.Data.Transactions;
using SAESP.Users.Application.Interfaces;
using SAESP.Users.Application.Services.Base;
using SAESP.Users.Domain.Commands.Handlers;
using SAESP.Users.Domain.Commands.Inputs;
using System;

namespace SAESP.Users.Application.Services
{
    public class UserApplication : BaseApplication, IUserApplication
    {
        private readonly UserCommandHandler _handler;

        public UserApplication(IUow uow, UserCommandHandler handler)
            : base(uow)
        {
            _handler = handler;
        }

        public ICommandResult AddUser(RegisterUserCommand command)
        {
            _handler.Handle(command);

            if ( Commit() )
            {
                Console.WriteLine("1 ou n ações após o evento de domínio (Registrar usuário) ocorrer com sucesso, por exemplo: Enviar email de boas vindas.");
            }

            return null;
        }
    }
}