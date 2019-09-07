using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using Model;

namespace Repository
{
   public class PostRepository : BaseRepository, IPostRepository
    {
        public async Task Create(Post post)
        {
            post.Id = Guid.NewGuid();
            const string sql = "insert into post (id, creator, description, UserId) values (@Id,@Creator,@Description,@UserId)";
            using (var connection = GetConnection())
            {
                await connection.ExecuteAsync(sql, post);
            }
        }

        public async Task<IEnumerable<Post>> GetAll()
        {
            const string sql = "select * from post";
            using (var connection = GetConnection())
            {
                return await connection.QueryAsync<Post>(sql);
            }
        }
    }
}