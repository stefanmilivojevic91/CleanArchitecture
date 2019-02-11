using Domain.Entities;
using Domain.PortsAndAdapters.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        public Task<User> GetByUsername(string username)
        {
            return Task.FromResult<User>(null);
        }
    }
}
