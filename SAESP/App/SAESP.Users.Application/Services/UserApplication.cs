using SAESP.Domain.Core.Commands;
using SAESP.Infra.Data.Transactions;
using SAESP.Users.Application.Interfaces;
using SAESP.Users.Application.Services.Base;
using SAESP.Users.Domain.Commands.Handlers;
using SAESP.Users.Domain.Commands.Inputs;
using SAESP.Users.Domain.Commands.Results;
using SAESP.Users.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace SAESP.Users.Application.Services
{
    public class UserApplication : BaseApplication, IUserApplication
    {
        private readonly UserCommandHandler _handler;
        private readonly IUserRepository _userRepository;

        public UserApplication(IUow uow, IUserRepository userRepository, UserCommandHandler handler)
            : base(uow)
        {
            _handler = handler;
            _userRepository = userRepository;
        }

        public ICommandResult AddUser(RegisterUserCommand command)
        {
            var result = _handler.Handle(command);

            if ( Commit() )
            {
                Console.WriteLine("1 ou n ações, após o evento de domínio (Registrar usuário) ocorrer com sucesso, por exemplo: Enviar email de boas vindas.");
            }

            return result;
        }

        public IEnumerable<GetUsersListCommandResult> GetUsers()
        {
            return _userRepository.GetUsers();
        }
    }
}