using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Model;
using Repository;

namespace Business
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserRepository _repository;

        public UserBusiness(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task CreateUser(CreateUserDto userDto)
        {
            var user = new User(userDto.Name, userDto.ImageUrl, userDto.Password, userDto.Email);

            await _repository.CreateUser(user);
        }

        public Task<IEnumerable<User>> GetAll()
        {
            return _repository.GetAll();
        }

        public async Task<User> GetById(Guid id)
        {
            return await _repository.GetUser(id);
            ;
        }
    }
}