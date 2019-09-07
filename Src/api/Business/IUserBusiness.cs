using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Model;

namespace Business
{
    public interface IUserBusiness
    {
        Task CreateUser(CreateUserDto user);
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(Guid id);
    }
}