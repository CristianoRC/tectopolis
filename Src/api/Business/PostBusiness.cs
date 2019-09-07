using System;
using System.Threading.Tasks;
using Model;
using Repository;

namespace Business
{
    public class PostBusiness : IPostBusiness
    {
        private readonly IPostRepository _repository;

        public PostBusiness(IPostRepository repository)
        {
            _repository = repository;
        }

        public async Task<Post[]> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task CreatePost(Post post)
        {
            if (post.IsValid)
            {
                await _repository.Create(post);
            }
            else
            {
                throw new ArgumentException("Preencha todos os campos corretamente!");
            }
        }
    }
}