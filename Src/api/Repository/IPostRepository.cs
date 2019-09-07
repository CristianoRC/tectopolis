using System.Collections.Generic;
using System.Threading.Tasks;
using Model;

namespace Repository
{
    public interface IPostRepository
    {
        Task Create(Post post);
        Task<IEnumerable<Post>> GetAll();
    }
}