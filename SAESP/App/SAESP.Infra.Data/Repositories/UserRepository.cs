using SAESP.Infra.Data.Context;
using SAESP.Users.Domain.Entities;
using SAESP.Users.Domain.Repositories;
using SAESP.Users.Domain.ValueObjects;
using System.Linq;
using SAESP.Users.Domain.Commands.Results;
using System.Collections.Generic;

namespace SAESP.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SaespContext _context;

        public UserRepository(SaespContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
        }

        public User GetByEmail(Email email)
        {
            return _context.Users
                .FirstOrDefault(x => x.Email.Mail == email.Mail);
        }

        public IEnumerable<GetUsersListCommandResult> GetUsers()//int take, int skip)
        {
            var users = _context.Users.ToList();
            var usersResult = new List<GetUsersListCommandResult>();

            foreach (var u in users)
            {
                usersResult.Add(new GetUsersListCommandResult
                    { Id = u.Id, FirstName = u.Name.FirstName, LastName = u.Name.LastName, Email = u.Email.Mail }
                );
            }

            return usersResult;

            //var query = "SELECT [Id], [FirstName], [LastName], [Email] FROM [User]";
            //using (var conn = new SqlConnection(Configuration.ConnectionString))
            //{
            //    conn.Open();
            //    return conn.Query<GetUsersListCommandResult>(query);
            //}
        }
    }
}