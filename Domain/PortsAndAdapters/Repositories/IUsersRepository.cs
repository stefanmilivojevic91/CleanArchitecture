using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.PortsAndAdapters.Repositories
{
    public interface IUsersRepository
    {
        Task<User> GetByUsername(string username);
    }
}
