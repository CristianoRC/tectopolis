using System.Collections.Generic;
using System.Threading.Tasks;
using Model;

namespace Business
{
    public interface IPostBusiness
    {
        Task<IEnumerable<Post>> GetAll();

        Task CreatePost(Post post);
    }
}