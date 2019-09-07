using System.Threading.Tasks;
using Model;

namespace Repository
{
    class PostRepository : BaseRepository, IPostRepository
    {
        public async Task Create(Post post)
        {
            using (var connection = GetConnection())
            {
            }
        }

        public async Task<Post[]> GetAll()
        {
            using (var connection = GetConnection())
            {
                return new Post[0];
            }
        }
    }
}