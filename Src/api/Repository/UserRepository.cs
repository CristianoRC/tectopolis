using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using Model;

namespace Repository
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public async Task CreateUser(User user)
        {
            user.Id = Guid.NewGuid();

            const string sql = "insert into public.user values (@Id,@Name,@ImageUrl,@Password,@Email)";

            using (var connection = GetConnection())
            {
                await connection.ExecuteAsync(sql, user);
            }
        }

        public async Task<User> GetUser(Guid userId)
        {
            const string sql = "select * from public.user where id=@Id";
            using (var connection = GetConnection())
            {
                return await connection.QueryFirstOrDefaultAsync<User>(sql, new {Id = userId});
            }
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            const string sql = "select * from public.user";
            using (var connection = GetConnection())
            {
                return await connection.QueryAsync<User>(sql);
            }
        }
    }
}