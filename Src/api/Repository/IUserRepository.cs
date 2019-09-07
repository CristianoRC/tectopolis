using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Model;

namespace Repository
{
    public interface IUserRepository
    {
        Task CreateUser(User user);
        
        Task<User> GetUser(Guid userId);
        
        Task<IEnumerable<User>> GetAll();
    }
}