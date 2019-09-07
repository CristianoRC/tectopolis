using System.Threading.Tasks;
using Model;

namespace Business
{
    public interface IPostBusiness
    {
        Task<Post[]> GetAll();

        Task CreatePost(Post post);
    }
}